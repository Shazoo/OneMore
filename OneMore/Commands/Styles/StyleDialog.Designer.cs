﻿namespace River.OneMoreAddIn.Commands
{
	partial class StyleDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				selection?.Dispose();
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleDialog));
			this.sizeBox = new System.Windows.Forms.ComboBox();
			this.beforeLabel = new System.Windows.Forms.Label();
			this.afterLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.fontLabel = new System.Windows.Forms.Label();
			this.spaceBeforeSpinner = new System.Windows.Forms.NumericUpDown();
			this.spaceAfterSpinner = new System.Windows.Forms.NumericUpDown();
			this.previewBox = new System.Windows.Forms.PictureBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.namesBox = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.styleTypeLabel = new System.Windows.Forms.Label();
			this.styleTypeBox = new System.Windows.Forms.ComboBox();
			this.applyColorsBox = new System.Windows.Forms.CheckBox();
			this.familyBox = new River.OneMoreAddIn.UI.FontComboBox();
			this.toolStrip = new River.OneMoreAddIn.UI.ScaledToolStrip();
			this.boldButton = new System.Windows.Forms.ToolStripButton();
			this.italicButton = new System.Windows.Forms.ToolStripButton();
			this.underlineButton = new System.Windows.Forms.ToolStripButton();
			this.strikeButton = new System.Windows.Forms.ToolStripButton();
			this.superButton = new System.Windows.Forms.ToolStripButton();
			this.subButton = new System.Windows.Forms.ToolStripButton();
			this.backColorButton = new System.Windows.Forms.ToolStripSplitButton();
			this.transparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorButton = new System.Windows.Forms.ToolStripSplitButton();
			this.defaultBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainTools = new River.OneMoreAddIn.UI.ScaledToolStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this.loadButton = new System.Windows.Forms.ToolStripMenuItem();
			this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
			this.newStyleButton = new System.Windows.Forms.ToolStripButton();
			this.reorderButton = new System.Windows.Forms.ToolStripButton();
			this.deleteButton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.spaceBeforeSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spaceAfterSpinner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.mainTools.SuspendLayout();
			this.SuspendLayout();
			// 
			// sizeBox
			// 
			this.sizeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sizeBox.FormattingEnabled = true;
			this.sizeBox.Items.AddRange(new object[] {
            "8",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26"});
			this.sizeBox.Location = new System.Drawing.Point(322, 68);
			this.sizeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.sizeBox.Name = "sizeBox";
			this.sizeBox.Size = new System.Drawing.Size(71, 23);
			this.sizeBox.TabIndex = 4;
			this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.ChangeFontSize);
			// 
			// beforeLabel
			// 
			this.beforeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.beforeLabel.AutoSize = true;
			this.beforeLabel.Location = new System.Drawing.Point(12, 148);
			this.beforeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.beforeLabel.Name = "beforeLabel";
			this.beforeLabel.Size = new System.Drawing.Size(75, 13);
			this.beforeLabel.TabIndex = 6;
			this.beforeLabel.Text = "Space Before:";
			// 
			// afterLabel
			// 
			this.afterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.afterLabel.AutoSize = true;
			this.afterLabel.Location = new System.Drawing.Point(12, 172);
			this.afterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.afterLabel.Name = "afterLabel";
			this.afterLabel.Size = new System.Drawing.Size(66, 13);
			this.afterLabel.TabIndex = 7;
			this.afterLabel.Text = "Space After:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(12, 19);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(64, 13);
			this.nameLabel.TabIndex = 8;
			this.nameLabel.Text = "Style Name:";
			// 
			// nameBox
			// 
			this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameBox.Location = new System.Drawing.Point(97, 15);
			this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(297, 23);
			this.nameBox.TabIndex = 1;
			this.nameBox.TextChanged += new System.EventHandler(this.ChangeStyleName);
			// 
			// fontLabel
			// 
			this.fontLabel.AutoSize = true;
			this.fontLabel.Location = new System.Drawing.Point(12, 77);
			this.fontLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fontLabel.Name = "fontLabel";
			this.fontLabel.Size = new System.Drawing.Size(31, 13);
			this.fontLabel.TabIndex = 10;
			this.fontLabel.Text = "Font:";
			// 
			// spaceBeforeSpinner
			// 
			this.spaceBeforeSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.spaceBeforeSpinner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spaceBeforeSpinner.Location = new System.Drawing.Point(97, 144);
			this.spaceBeforeSpinner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.spaceBeforeSpinner.Name = "spaceBeforeSpinner";
			this.spaceBeforeSpinner.Size = new System.Drawing.Size(72, 23);
			this.spaceBeforeSpinner.TabIndex = 7;
			this.spaceBeforeSpinner.ValueChanged += new System.EventHandler(this.ChangeSpaceBefore);
			// 
			// spaceAfterSpinner
			// 
			this.spaceAfterSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.spaceAfterSpinner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spaceAfterSpinner.Location = new System.Drawing.Point(97, 168);
			this.spaceAfterSpinner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.spaceAfterSpinner.Name = "spaceAfterSpinner";
			this.spaceAfterSpinner.Size = new System.Drawing.Size(72, 23);
			this.spaceAfterSpinner.TabIndex = 8;
			this.spaceAfterSpinner.ValueChanged += new System.EventHandler(this.ChangeSpaceAfter);
			// 
			// previewBox
			// 
			this.previewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.previewBox.BackColor = System.Drawing.Color.White;
			this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewBox.Location = new System.Drawing.Point(185, 144);
			this.previewBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.previewBox.Name = "previewBox";
			this.previewBox.Size = new System.Drawing.Size(207, 70);
			this.previewBox.TabIndex = 18;
			this.previewBox.TabStop = false;
			this.previewBox.Paint += new System.Windows.Forms.PaintEventHandler(this.RepaintSample);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(315, 239);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(77, 25);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(235, 239);
			this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(77, 25);
			this.okButton.TabIndex = 9;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// namesBox
			// 
			this.namesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.namesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.namesBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namesBox.FormattingEnabled = true;
			this.namesBox.Location = new System.Drawing.Point(12, 242);
			this.namesBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.namesBox.Name = "namesBox";
			this.namesBox.Size = new System.Drawing.Size(82, 23);
			this.namesBox.TabIndex = 21;
			this.namesBox.Visible = false;
			this.namesBox.SelectedIndexChanged += new System.EventHandler(this.ChangeStyleListSelection);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.styleTypeLabel);
			this.panel1.Controls.Add(this.styleTypeBox);
			this.panel1.Controls.Add(this.applyColorsBox);
			this.panel1.Controls.Add(this.nameLabel);
			this.panel1.Controls.Add(this.familyBox);
			this.panel1.Controls.Add(this.toolStrip);
			this.panel1.Controls.Add(this.okButton);
			this.panel1.Controls.Add(this.cancelButton);
			this.panel1.Controls.Add(this.sizeBox);
			this.panel1.Controls.Add(this.beforeLabel);
			this.panel1.Controls.Add(this.namesBox);
			this.panel1.Controls.Add(this.afterLabel);
			this.panel1.Controls.Add(this.nameBox);
			this.panel1.Controls.Add(this.fontLabel);
			this.panel1.Controls.Add(this.previewBox);
			this.panel1.Controls.Add(this.spaceAfterSpinner);
			this.panel1.Controls.Add(this.spaceBeforeSpinner);
			this.panel1.Location = new System.Drawing.Point(5, 26);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10, 13, 10, 6);
			this.panel1.Size = new System.Drawing.Size(404, 272);
			this.panel1.TabIndex = 25;
			// 
			// styleTypeLabel
			// 
			this.styleTypeLabel.AutoSize = true;
			this.styleTypeLabel.Location = new System.Drawing.Point(12, 44);
			this.styleTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.styleTypeLabel.Name = "styleTypeLabel";
			this.styleTypeLabel.Size = new System.Drawing.Size(60, 13);
			this.styleTypeLabel.TabIndex = 27;
			this.styleTypeLabel.Text = "Style Type:";
			// 
			// styleTypeBox
			// 
			this.styleTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.styleTypeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.styleTypeBox.FormattingEnabled = true;
			this.styleTypeBox.Items.AddRange(new object[] {
            "Character - words in paragraph",
            "Paragraph - entire paragraph",
            "Heading - include in TOC"});
			this.styleTypeBox.Location = new System.Drawing.Point(97, 40);
			this.styleTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.styleTypeBox.Name = "styleTypeBox";
			this.styleTypeBox.Size = new System.Drawing.Size(297, 23);
			this.styleTypeBox.TabIndex = 2;
			this.styleTypeBox.SelectedIndexChanged += new System.EventHandler(this.ChangeStyleType);
			// 
			// applyColorsBox
			// 
			this.applyColorsBox.AutoSize = true;
			this.applyColorsBox.Checked = true;
			this.applyColorsBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.applyColorsBox.Location = new System.Drawing.Point(312, 103);
			this.applyColorsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.applyColorsBox.Name = "applyColorsBox";
			this.applyColorsBox.Size = new System.Drawing.Size(83, 17);
			this.applyColorsBox.TabIndex = 6;
			this.applyColorsBox.Text = "Apply colors";
			this.applyColorsBox.UseVisualStyleBackColor = true;
			this.applyColorsBox.CheckedChanged += new System.EventHandler(this.ChangeApplyColorsOption);
			// 
			// familyBox
			// 
			this.familyBox.DropDownHeight = 400;
			this.familyBox.DropDownWidth = 350;
			this.familyBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.familyBox.FormattingEnabled = true;
			this.familyBox.IntegralHeight = false;
			this.familyBox.Items.AddRange(new object[] {
            "Agency FB",
            "Algerian",
            "Antitled OT Medium",
            "AntitledBook",
            "AntitledRegular",
            "Arial",
            "Arial Black",
            "Arial Narrow",
            "Arial Rounded MT Bold",
            "Bahnschrift",
            "Bahnschrift Light",
            "Bahnschrift SemiBold",
            "Bahnschrift SemiLight",
            "Baskerville Old Face",
            "Bauhaus 93",
            "Bell MT",
            "Berlin Sans FB",
            "Berlin Sans FB Demi",
            "Bernard MT Condensed",
            "Blackadder ITC",
            "Bodoni MT",
            "Bodoni MT Black",
            "Bodoni MT Condensed",
            "Bodoni MT Poster Compressed",
            "Book Antiqua",
            "Bookman Old Style",
            "Bookshelf Symbol 7",
            "Bradley Hand ITC",
            "Britannic Bold",
            "Broadway",
            "Brush Script MT",
            "Calibri",
            "Calibri Light",
            "Californian FB",
            "Calisto MT",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Castellar",
            "Centaur",
            "Century",
            "Century Gothic",
            "Century Schoolbook",
            "Chiller",
            "ChollaSans",
            "ChollaSans-Thin",
            "ChollaSans Thin",
            "ChollaSansBold",
            "ChollaUnicase",
            "Colonna MT",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Cooper Black",
            "Copperplate Gothic Bold",
            "Copperplate Gothic Light",
            "Corbel",
            "Courier New",
            "Curlz MT",
            "DRAFTSMAN",
            "Ebrima",
            "Edwardian Script ITC",
            "Elephant",
            "Engravers MT",
            "Eras Bold ITC",
            "Eras Demi ITC",
            "Eras Light ITC",
            "Eras Medium ITC",
            "Felix Titling",
            "Footlight MT Light",
            "Forte",
            "Franklin Gothic Book",
            "Franklin Gothic Demi",
            "Franklin Gothic Demi Cond",
            "Franklin Gothic Heavy",
            "Franklin Gothic Medium",
            "Franklin Gothic Medium Cond",
            "Freestyle Script",
            "French Script MT",
            "Futura Lt BT",
            "Gabriola",
            "Gadugi",
            "Garamond",
            "Georgia",
            "Gigi",
            "Gill Sans MT",
            "Gill Sans MT Condensed",
            "Gill Sans MT Ext Condensed Bold",
            "Gill Sans Ultra Bold",
            "Gill Sans Ultra Bold Condensed",
            "Gloucester MT Extra Condensed",
            "Goudy Old Style",
            "Goudy Stout",
            "Haettenschweiler",
            "Harlow Solid Italic",
            "Harrington",
            "HelvLight",
            "High Tower Text",
            "HoloLens MDL2 Assets",
            "Impact",
            "Imprint MT Shadow",
            "Informal Roman",
            "Javanese Text",
            "Jokerman",
            "Juice ITC",
            "Kristen ITC",
            "Kunstler Script",
            "Lato",
            "Leelawadee UI",
            "Leelawadee UI Semilight",
            "Lucida Bright",
            "Lucida Calligraphy",
            "Lucida Console",
            "Lucida Fax",
            "Lucida Handwriting",
            "Lucida Sans",
            "Lucida Sans Typewriter",
            "Lucida Sans Unicode",
            "Magneto",
            "Maiandra GD",
            "Malgun Gothic",
            "Malgun Gothic Semilight",
            "Marlett",
            "Matura MT Script Capitals",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft JhengHei Light",
            "Microsoft JhengHei UI",
            "Microsoft JhengHei UI Light",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft YaHei",
            "Microsoft YaHei Light",
            "Microsoft YaHei UI",
            "Microsoft YaHei UI Light",
            "Microsoft Yi Baiti",
            "MingLiU-ExtB",
            "MingLiU_HKSCS-ExtB",
            "Mistral",
            "Modern No. 20",
            "Mongolian Baiti",
            "Monotype Corsiva",
            "MS Gothic",
            "MS Outlook",
            "MS PGothic",
            "MS Reference Sans Serif",
            "MS Reference Specialty",
            "MS UI Gothic",
            "MT Extra",
            "MV Boli",
            "Myanmar Text",
            "Niagara Engraved",
            "Niagara Solid",
            "Nirmala UI",
            "Nirmala UI Semilight",
            "NSimSun",
            "OCR-A II",
            "OCR A Extended",
            "OCR B MT",
            "Old English Text MT",
            "Onyx",
            "Open Sans",
            "Open Sans Extrabold",
            "Open Sans Light",
            "Open Sans Semibold",
            "Palace Script MT",
            "Palatino Linotype",
            "Papyrus",
            "Parchment",
            "Perpetua",
            "Perpetua Titling MT",
            "Playbill",
            "PMingLiU-ExtB",
            "Poor Richard",
            "Pristina",
            "QuickType II",
            "QuickType II Condensed",
            "QuickType II Mono",
            "QuickType II Pi",
            "Rage Italic",
            "Ravie",
            "Rockwell",
            "Rockwell Condensed",
            "Rockwell Extra Bold",
            "Script MT Bold",
            "Segoe MDL2 Assets",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI",
            "Segoe UI Black",
            "Segoe UI Emoji",
            "Segoe UI Historic",
            "Segoe UI Light",
            "Segoe UI Semibold",
            "Segoe UI Semilight",
            "Segoe UI Symbol",
            "Showcard Gothic",
            "SimSun",
            "SimSun-ExtB",
            "Sitka Banner",
            "Sitka Display",
            "Sitka Heading",
            "Sitka Small",
            "Sitka Subheading",
            "Sitka Text",
            "SMC Handwriting",
            "Snap ITC",
            "Stencil",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "TeamViewer11",
            "Tempus Sans ITC",
            "Times New Roman",
            "Trajan Pro",
            "Trebuchet MS",
            "Tw Cen MT",
            "Tw Cen MT Condensed",
            "Tw Cen MT Condensed Extra Bold",
            "Verdana",
            "Viner Hand ITC",
            "Vivaldi",
            "Vladimir Script",
            "Webdings",
            "Wide Latin",
            "Wingdings",
            "Wingdings 2",
            "Wingdings 3",
            "Yu Gothic",
            "Yu Gothic Light",
            "Yu Gothic Medium",
            "Yu Gothic UI",
            "Yu Gothic UI Light",
            "Yu Gothic UI Semibold",
            "Yu Gothic UI Semilight",
            "ZWAdobeF"});
			this.familyBox.Location = new System.Drawing.Point(97, 68);
			this.familyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.familyBox.Name = "familyBox";
			this.familyBox.Size = new System.Drawing.Size(217, 24);
			this.familyBox.TabIndex = 3;
			this.familyBox.SelectedIndexChanged += new System.EventHandler(this.ChangeFontFamily);
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.strikeButton,
            this.superButton,
            this.subButton,
            this.backColorButton,
            this.colorButton});
			this.toolStrip.Location = new System.Drawing.Point(97, 97);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip.Size = new System.Drawing.Size(212, 25);
			this.toolStrip.TabIndex = 5;
			// 
			// boldButton
			// 
			this.boldButton.CheckOnClick = true;
			this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
			this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.boldButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.boldButton.Name = "boldButton";
			this.boldButton.Size = new System.Drawing.Size(23, 20);
			this.boldButton.Text = "Bold";
			this.boldButton.CheckStateChanged += new System.EventHandler(this.ChangeFontStyle);
			// 
			// italicButton
			// 
			this.italicButton.CheckOnClick = true;
			this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
			this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.italicButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.italicButton.Name = "italicButton";
			this.italicButton.Size = new System.Drawing.Size(23, 20);
			this.italicButton.Text = "Italic";
			this.italicButton.CheckStateChanged += new System.EventHandler(this.ChangeFontStyle);
			// 
			// underlineButton
			// 
			this.underlineButton.CheckOnClick = true;
			this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
			this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.underlineButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.underlineButton.Name = "underlineButton";
			this.underlineButton.Size = new System.Drawing.Size(23, 20);
			this.underlineButton.Text = "Underline";
			this.underlineButton.CheckStateChanged += new System.EventHandler(this.ChangeFontStyle);
			// 
			// strikeButton
			// 
			this.strikeButton.CheckOnClick = true;
			this.strikeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.strikeButton.Image = ((System.Drawing.Image)(resources.GetObject("strikeButton.Image")));
			this.strikeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.strikeButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.strikeButton.Name = "strikeButton";
			this.strikeButton.Size = new System.Drawing.Size(23, 20);
			this.strikeButton.Text = "Strikethrough";
			this.strikeButton.CheckStateChanged += new System.EventHandler(this.ChangeFontStyle);
			// 
			// superButton
			// 
			this.superButton.CheckOnClick = true;
			this.superButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.superButton.Image = ((System.Drawing.Image)(resources.GetObject("superButton.Image")));
			this.superButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.superButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.superButton.Name = "superButton";
			this.superButton.Size = new System.Drawing.Size(23, 20);
			this.superButton.Text = "Superscript";
			this.superButton.CheckStateChanged += new System.EventHandler(this.ChangeFontStyle);
			this.superButton.Click += new System.EventHandler(this.ToggleSuperSub);
			// 
			// subButton
			// 
			this.subButton.CheckOnClick = true;
			this.subButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.subButton.Image = ((System.Drawing.Image)(resources.GetObject("subButton.Image")));
			this.subButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.subButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.subButton.Name = "subButton";
			this.subButton.Size = new System.Drawing.Size(23, 20);
			this.subButton.Text = "Subscript";
			this.subButton.CheckStateChanged += new System.EventHandler(this.ChangeFontStyle);
			this.subButton.Click += new System.EventHandler(this.ToggleSuperSub);
			// 
			// backColorButton
			// 
			this.backColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.backColorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transparentToolStripMenuItem});
			this.backColorButton.Image = ((System.Drawing.Image)(resources.GetObject("backColorButton.Image")));
			this.backColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backColorButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.backColorButton.Name = "backColorButton";
			this.backColorButton.Size = new System.Drawing.Size(32, 20);
			this.backColorButton.ToolTipText = "Highlight Color";
			this.backColorButton.ButtonClick += new System.EventHandler(this.ChangeHighlightColor);
			// 
			// transparentToolStripMenuItem
			// 
			this.transparentToolStripMenuItem.Name = "transparentToolStripMenuItem";
			this.transparentToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.transparentToolStripMenuItem.Text = "Transparent";
			this.transparentToolStripMenuItem.Click += new System.EventHandler(this.ChangeHighlightToDefault);
			// 
			// colorButton
			// 
			this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.colorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultBlackToolStripMenuItem});
			this.colorButton.Image = ((System.Drawing.Image)(resources.GetObject("colorButton.Image")));
			this.colorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.colorButton.Margin = new System.Windows.Forms.Padding(0, 2, 1, 3);
			this.colorButton.Name = "colorButton";
			this.colorButton.Size = new System.Drawing.Size(32, 20);
			this.colorButton.ToolTipText = "Text Color";
			this.colorButton.ButtonClick += new System.EventHandler(this.ChangeColor);
			// 
			// defaultBlackToolStripMenuItem
			// 
			this.defaultBlackToolStripMenuItem.Name = "defaultBlackToolStripMenuItem";
			this.defaultBlackToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.defaultBlackToolStripMenuItem.Text = "Default (Black)";
			this.defaultBlackToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorToDefault);
			// 
			// mainTools
			// 
			this.mainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.newStyleButton,
            this.reorderButton,
            this.deleteButton});
			this.mainTools.Location = new System.Drawing.Point(3, 3);
			this.mainTools.Name = "mainTools";
			this.mainTools.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.mainTools.Size = new System.Drawing.Size(411, 25);
			this.mainTools.TabIndex = 0;
			// 
			// FileMenu
			// 
			this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadButton,
            this.saveButton});
			this.FileMenu.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu.Image")));
			this.FileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(38, 28);
			this.FileMenu.Text = "File";
			// 
			// loadButton
			// 
			this.loadButton.Image = global::River.OneMoreAddIn.Properties.Resources.Open;
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(121, 22);
			this.loadButton.Text = "Open...";
			this.loadButton.Click += new System.EventHandler(this.LoadTheme);
			// 
			// saveButton
			// 
			this.saveButton.Image = global::River.OneMoreAddIn.Properties.Resources.SaveAs;
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(121, 22);
			this.saveButton.Text = "Save as...";
			this.saveButton.Click += new System.EventHandler(this.SaveTheme);
			// 
			// newStyleButton
			// 
			this.newStyleButton.Image = global::River.OneMoreAddIn.Properties.Resources.NewStyle;
			this.newStyleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newStyleButton.Name = "newStyleButton";
			this.newStyleButton.Size = new System.Drawing.Size(87, 28);
			this.newStyleButton.Text = "New Style";
			this.newStyleButton.Click += new System.EventHandler(this.AddStyle);
			// 
			// reorderButton
			// 
			this.reorderButton.Image = ((System.Drawing.Image)(resources.GetObject("reorderButton.Image")));
			this.reorderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reorderButton.Name = "reorderButton";
			this.reorderButton.Size = new System.Drawing.Size(76, 28);
			this.reorderButton.Text = "Reorder";
			this.reorderButton.Click += new System.EventHandler(this.ReorderStyles);
			// 
			// deleteButton
			// 
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(68, 28);
			this.deleteButton.Text = "Delete";
			this.deleteButton.Click += new System.EventHandler(this.DeleteStyle);
			// 
			// StyleDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(414, 303);
			this.Controls.Add(this.mainTools);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.Name = "StyleDialog";
			this.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Custom Styles";
			this.Shown += new System.EventHandler(this.StyleDialog_Shown);
			((System.ComponentModel.ISupportInitialize)(this.spaceBeforeSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spaceAfterSpinner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.mainTools.ResumeLayout(false);
			this.mainTools.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UI.FontComboBox familyBox;
		private System.Windows.Forms.ComboBox sizeBox;
		private System.Windows.Forms.Label beforeLabel;
		private System.Windows.Forms.Label afterLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label fontLabel;
		private UI.ScaledToolStrip toolStrip;
		private System.Windows.Forms.ToolStripSplitButton colorButton;
		private System.Windows.Forms.NumericUpDown spaceBeforeSpinner;
		private System.Windows.Forms.NumericUpDown spaceAfterSpinner;
		private System.Windows.Forms.ToolStripSplitButton backColorButton;
		private System.Windows.Forms.PictureBox previewBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ComboBox namesBox;
		private System.Windows.Forms.ToolStripMenuItem transparentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem defaultBlackToolStripMenuItem;
		private UI.ScaledToolStrip mainTools;
		private System.Windows.Forms.ToolStripButton reorderButton;
		private System.Windows.Forms.ToolStripButton deleteButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripButton boldButton;
		private System.Windows.Forms.ToolStripButton italicButton;
		private System.Windows.Forms.ToolStripButton underlineButton;
		private System.Windows.Forms.CheckBox applyColorsBox;
		private System.Windows.Forms.Label styleTypeLabel;
		private System.Windows.Forms.ComboBox styleTypeBox;
		private System.Windows.Forms.ToolStripButton strikeButton;
		private System.Windows.Forms.ToolStripButton superButton;
		private System.Windows.Forms.ToolStripButton subButton;
		private System.Windows.Forms.ToolStripDropDownButton FileMenu;
		private System.Windows.Forms.ToolStripMenuItem loadButton;
		private System.Windows.Forms.ToolStripMenuItem saveButton;
		private System.Windows.Forms.ToolStripButton newStyleButton;
	}
}