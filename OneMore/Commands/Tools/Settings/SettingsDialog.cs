﻿//************************************************************************************************
// Copyright © 2020 Steven M. Cohn. All Rights Reserved.
//************************************************************************************************

namespace River.OneMoreAddIn.Settings
{
	using System;
	using System.Collections.Generic;
	using System.Windows.Forms;
	using Resx = River.OneMoreAddIn.Properties.Resources;


	internal partial class SettingsDialog : UI.LocalizableForm
	{
		private readonly Dictionary<int, SheetBase> sheets;
		private readonly SettingsProvider provider;


		public SettingsDialog()
		{
			InitializeComponent();

			if (NeedsLocalizing())
			{
				Text = Resx.SettingsDialog_Text;

				Localize(new string[]
				{
					"okButton",
					"cancelButton"
				});

				navTree.Nodes["contextNode"].Text = Resx.SettingsDialog_contextNode_Text;
				navTree.Nodes["highlightNode"].Text = Resx.SettingsDialog_highlightNode_Text;
				navTree.Nodes["ribbonNode"].Text = Resx.SettingsDialog_ribbonNode_Text;
				navTree.Nodes["searchNode"].Text = Resx.SettingsDialog_searchNode_Text;
			}

			provider = new SettingsProvider();
			sheets = new Dictionary<int, SheetBase>();

			navTree.SelectedNode = navTree.Nodes[0];
			navTree.Focus();
		}


		protected override void OnShown(EventArgs e)
		{
			Location = new System.Drawing.Point(Location.X, Location.Y - (Height / 5));
			UIHelper.SetForegroundWindow(this);
		}


		private void Navigate(object sender, TreeViewEventArgs e)
		{
			SheetBase sheet;

			if (sheets.ContainsKey(e.Node.Index))
			{
				sheet = sheets[e.Node.Index];
			}
			else
			{
				switch (e.Node.Index)
				{
					case 0: sheet = new ContextMenuSheet(provider); break;
					case 1: sheet = new HighlightsSheet(provider); break;
					case 2: sheet = new RibbonBarSheet(provider); break;
					default: sheet = new SearchEngineSheet(provider); break;
				}

				sheets.Add(e.Node.Index, sheet);
			}

			headerLabel.Text = sheet.Title;

			contentPanel.Controls.Clear();
			contentPanel.Controls.Add(sheet);
		}


		private void OK(object sender, EventArgs e)
		{
			foreach (var sheet in sheets.Values)
			{
				sheet.CollectSettings();
			}

			provider.Save();

			UIHelper.ShowMessage(Resx.SettingsDialog_Restart);

			Logger.Current.WriteLine("user settings saved");
		}
	}
}
