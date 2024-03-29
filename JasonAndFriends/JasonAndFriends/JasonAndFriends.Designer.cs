﻿namespace JasonAndFriends
{
    partial class JasonAndFriends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSelFriends = new System.Windows.Forms.ComboBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.buttonNewFriend = new System.Windows.Forms.Button();
            this.buttonDelFriend = new System.Windows.Forms.Button();
            this.panelFriendInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWillWantNew = new System.Windows.Forms.Button();
            this.buttonWillWantRem = new System.Windows.Forms.Button();
            this.buttonWillWantEdt = new System.Windows.Forms.Button();
            this.labelWillWant = new System.Windows.Forms.Label();
            this.panelDietary = new System.Windows.Forms.Panel();
            this.labelDietary = new System.Windows.Forms.Label();
            this.radioButtonDietaryYes = new System.Windows.Forms.RadioButton();
            this.radioButtonDietaryNo = new System.Windows.Forms.RadioButton();
            this.panelCanDrink = new System.Windows.Forms.Panel();
            this.labelCanDrink = new System.Windows.Forms.Label();
            this.radioButtonCanDrinkYes = new System.Windows.Forms.RadioButton();
            this.radioButtonCanDrinkNo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxWillBring = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelWillBring = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWillBringNew = new System.Windows.Forms.Button();
            this.buttonWillBringRem = new System.Windows.Forms.Button();
            this.buttonWillBringEdt = new System.Windows.Forms.Button();
            this.labelWillBring = new System.Windows.Forms.Label();
            this.buttonResetFriend = new System.Windows.Forms.Button();
            this.buttonSaveFriend = new System.Windows.Forms.Button();
            this.textBoxFriendName = new System.Windows.Forms.TextBox();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.listBoxWillWant = new System.Windows.Forms.ListBox();
            this.panelFriendInfo.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDietary.SuspendLayout();
            this.panelCanDrink.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelWillBring.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelFriends
            // 
            this.comboBoxSelFriends.AllowDrop = true;
            this.comboBoxSelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSelFriends.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelFriends.FormattingEnabled = true;
            this.comboBoxSelFriends.Location = new System.Drawing.Point(48, 7);
            this.comboBoxSelFriends.MinimumSize = new System.Drawing.Size(100, 0);
            this.comboBoxSelFriends.Name = "comboBoxSelFriends";
            this.comboBoxSelFriends.Size = new System.Drawing.Size(343, 21);
            this.comboBoxSelFriends.TabIndex = 0;
            this.comboBoxSelFriends.SelectedIndexChanged += new System.EventHandler(this.comboBoxFriends_SelectedIndexChanged);
            this.comboBoxSelFriends.Click += new System.EventHandler(this.comboBoxSelFriends_Click);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(4, 11);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(44, 13);
            this.labelFriends.TabIndex = 1;
            this.labelFriends.Text = "Friends:";
            // 
            // buttonNewFriend
            // 
            this.buttonNewFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewFriend.Location = new System.Drawing.Point(397, 7);
            this.buttonNewFriend.MaximumSize = new System.Drawing.Size(1000, 21);
            this.buttonNewFriend.Name = "buttonNewFriend";
            this.buttonNewFriend.Size = new System.Drawing.Size(75, 21);
            this.buttonNewFriend.TabIndex = 2;
            this.buttonNewFriend.Text = "New";
            this.buttonNewFriend.UseVisualStyleBackColor = true;
            this.buttonNewFriend.Click += new System.EventHandler(this.buttonNewFriend_Click);
            // 
            // buttonDelFriend
            // 
            this.buttonDelFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelFriend.Location = new System.Drawing.Point(478, 7);
            this.buttonDelFriend.MaximumSize = new System.Drawing.Size(1000, 21);
            this.buttonDelFriend.Name = "buttonDelFriend";
            this.buttonDelFriend.Size = new System.Drawing.Size(75, 21);
            this.buttonDelFriend.TabIndex = 3;
            this.buttonDelFriend.Text = "Remove";
            this.buttonDelFriend.UseVisualStyleBackColor = true;
            this.buttonDelFriend.Click += new System.EventHandler(this.buttonDelFriend_Click);
            // 
            // panelFriendInfo
            // 
            this.panelFriendInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriendInfo.Controls.Add(this.tableLayoutPanel);
            this.panelFriendInfo.Controls.Add(this.buttonResetFriend);
            this.panelFriendInfo.Controls.Add(this.buttonSaveFriend);
            this.panelFriendInfo.Controls.Add(this.textBoxFriendName);
            this.panelFriendInfo.Controls.Add(this.labelFriendName);
            this.panelFriendInfo.Controls.Add(this.comboBoxSelFriends);
            this.panelFriendInfo.Controls.Add(this.buttonDelFriend);
            this.panelFriendInfo.Controls.Add(this.labelFriends);
            this.panelFriendInfo.Controls.Add(this.buttonNewFriend);
            this.panelFriendInfo.Location = new System.Drawing.Point(2, 2);
            this.panelFriendInfo.Name = "panelFriendInfo";
            this.panelFriendInfo.Size = new System.Drawing.Size(560, 515);
            this.panelFriendInfo.TabIndex = 4;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.77778F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.22222F));
            this.tableLayoutPanel.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.panelDietary, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelCanDrink);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(7, 62);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(546, 421);
            this.tableLayoutPanel.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listBoxWillWant);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.labelWillWant);
            this.panel2.Location = new System.Drawing.Point(274, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 370);
            this.panel2.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.buttonWillWantNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonWillWantRem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonWillWantEdt, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonWillWantNew
            // 
            this.buttonWillWantNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWillWantNew.Location = new System.Drawing.Point(3, 3);
            this.buttonWillWantNew.Name = "buttonWillWantNew";
            this.buttonWillWantNew.Size = new System.Drawing.Size(81, 23);
            this.buttonWillWantNew.TabIndex = 0;
            this.buttonWillWantNew.Text = "New";
            this.buttonWillWantNew.UseVisualStyleBackColor = true;
            // 
            // buttonWillWantRem
            // 
            this.buttonWillWantRem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWillWantRem.Location = new System.Drawing.Point(90, 3);
            this.buttonWillWantRem.Name = "buttonWillWantRem";
            this.buttonWillWantRem.Size = new System.Drawing.Size(81, 23);
            this.buttonWillWantRem.TabIndex = 1;
            this.buttonWillWantRem.Text = "Remove";
            this.buttonWillWantRem.UseVisualStyleBackColor = true;
            // 
            // buttonWillWantEdt
            // 
            this.buttonWillWantEdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWillWantEdt.Location = new System.Drawing.Point(177, 3);
            this.buttonWillWantEdt.Name = "buttonWillWantEdt";
            this.buttonWillWantEdt.Size = new System.Drawing.Size(82, 23);
            this.buttonWillWantEdt.TabIndex = 2;
            this.buttonWillWantEdt.Text = "Edit";
            this.buttonWillWantEdt.UseVisualStyleBackColor = true;
            // 
            // labelWillWant
            // 
            this.labelWillWant.AutoSize = true;
            this.labelWillWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWillWant.Location = new System.Drawing.Point(0, 0);
            this.labelWillWant.Name = "labelWillWant";
            this.labelWillWant.Size = new System.Drawing.Size(73, 16);
            this.labelWillWant.TabIndex = 3;
            this.labelWillWant.Text = "Will Want";
            // 
            // panelDietary
            // 
            this.panelDietary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDietary.Controls.Add(this.labelDietary);
            this.panelDietary.Controls.Add(this.radioButtonDietaryYes);
            this.panelDietary.Controls.Add(this.radioButtonDietaryNo);
            this.panelDietary.Location = new System.Drawing.Point(3, 3);
            this.panelDietary.Name = "panelDietary";
            this.panelDietary.Size = new System.Drawing.Size(265, 39);
            this.panelDietary.TabIndex = 14;
            // 
            // labelDietary
            // 
            this.labelDietary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDietary.AutoSize = true;
            this.labelDietary.Location = new System.Drawing.Point(163, 0);
            this.labelDietary.Name = "labelDietary";
            this.labelDietary.Size = new System.Drawing.Size(98, 13);
            this.labelDietary.TabIndex = 10;
            this.labelDietary.Text = "Dietary Restrictions";
            // 
            // radioButtonDietaryYes
            // 
            this.radioButtonDietaryYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDietaryYes.AutoSize = true;
            this.radioButtonDietaryYes.Location = new System.Drawing.Point(166, 19);
            this.radioButtonDietaryYes.Name = "radioButtonDietaryYes";
            this.radioButtonDietaryYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonDietaryYes.TabIndex = 8;
            this.radioButtonDietaryYes.Text = "Yes";
            this.radioButtonDietaryYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonDietaryNo
            // 
            this.radioButtonDietaryNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDietaryNo.AutoSize = true;
            this.radioButtonDietaryNo.Checked = true;
            this.radioButtonDietaryNo.Location = new System.Drawing.Point(223, 19);
            this.radioButtonDietaryNo.Name = "radioButtonDietaryNo";
            this.radioButtonDietaryNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonDietaryNo.TabIndex = 9;
            this.radioButtonDietaryNo.TabStop = true;
            this.radioButtonDietaryNo.Text = "No";
            this.radioButtonDietaryNo.UseVisualStyleBackColor = true;
            // 
            // panelCanDrink
            // 
            this.panelCanDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanDrink.Controls.Add(this.labelCanDrink);
            this.panelCanDrink.Controls.Add(this.radioButtonCanDrinkYes);
            this.panelCanDrink.Controls.Add(this.radioButtonCanDrinkNo);
            this.panelCanDrink.Location = new System.Drawing.Point(274, 3);
            this.panelCanDrink.Name = "panelCanDrink";
            this.panelCanDrink.Size = new System.Drawing.Size(269, 39);
            this.panelCanDrink.TabIndex = 15;
            // 
            // labelCanDrink
            // 
            this.labelCanDrink.AutoSize = true;
            this.labelCanDrink.Location = new System.Drawing.Point(3, 0);
            this.labelCanDrink.Name = "labelCanDrink";
            this.labelCanDrink.Size = new System.Drawing.Size(101, 13);
            this.labelCanDrink.TabIndex = 11;
            this.labelCanDrink.Text = "Over 18 (Can Drink)";
            // 
            // radioButtonCanDrinkYes
            // 
            this.radioButtonCanDrinkYes.AutoSize = true;
            this.radioButtonCanDrinkYes.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCanDrinkYes.Name = "radioButtonCanDrinkYes";
            this.radioButtonCanDrinkYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCanDrinkYes.TabIndex = 12;
            this.radioButtonCanDrinkYes.Text = "Yes";
            this.radioButtonCanDrinkYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonCanDrinkNo
            // 
            this.radioButtonCanDrinkNo.AutoSize = true;
            this.radioButtonCanDrinkNo.Checked = true;
            this.radioButtonCanDrinkNo.Location = new System.Drawing.Point(65, 19);
            this.radioButtonCanDrinkNo.Name = "radioButtonCanDrinkNo";
            this.radioButtonCanDrinkNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonCanDrinkNo.TabIndex = 13;
            this.radioButtonCanDrinkNo.TabStop = true;
            this.radioButtonCanDrinkNo.Text = "No";
            this.radioButtonCanDrinkNo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listBoxWillBring);
            this.panel1.Controls.Add(this.tableLayoutPanelWillBring);
            this.panel1.Controls.Add(this.labelWillBring);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 370);
            this.panel1.TabIndex = 16;
            // 
            // listBoxWillBring
            // 
            this.listBoxWillBring.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWillBring.FormattingEnabled = true;
            this.listBoxWillBring.Location = new System.Drawing.Point(6, 50);
            this.listBoxWillBring.Name = "listBoxWillBring";
            this.listBoxWillBring.Size = new System.Drawing.Size(255, 303);
            this.listBoxWillBring.TabIndex = 6;
            // 
            // tableLayoutPanelWillBring
            // 
            this.tableLayoutPanelWillBring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelWillBring.ColumnCount = 3;
            this.tableLayoutPanelWillBring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelWillBring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelWillBring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelWillBring.Controls.Add(this.buttonWillBringNew, 0, 0);
            this.tableLayoutPanelWillBring.Controls.Add(this.buttonWillBringRem, 1, 0);
            this.tableLayoutPanelWillBring.Controls.Add(this.buttonWillBringEdt, 2, 0);
            this.tableLayoutPanelWillBring.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelWillBring.Name = "tableLayoutPanelWillBring";
            this.tableLayoutPanelWillBring.RowCount = 1;
            this.tableLayoutPanelWillBring.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelWillBring.Size = new System.Drawing.Size(258, 29);
            this.tableLayoutPanelWillBring.TabIndex = 4;
            // 
            // buttonWillBringNew
            // 
            this.buttonWillBringNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWillBringNew.Location = new System.Drawing.Point(3, 3);
            this.buttonWillBringNew.Name = "buttonWillBringNew";
            this.buttonWillBringNew.Size = new System.Drawing.Size(79, 23);
            this.buttonWillBringNew.TabIndex = 0;
            this.buttonWillBringNew.Text = "New";
            this.buttonWillBringNew.UseVisualStyleBackColor = true;
            // 
            // buttonWillBringRem
            // 
            this.buttonWillBringRem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWillBringRem.Location = new System.Drawing.Point(88, 3);
            this.buttonWillBringRem.Name = "buttonWillBringRem";
            this.buttonWillBringRem.Size = new System.Drawing.Size(80, 23);
            this.buttonWillBringRem.TabIndex = 1;
            this.buttonWillBringRem.Text = "Remove";
            this.buttonWillBringRem.UseVisualStyleBackColor = true;
            // 
            // buttonWillBringEdt
            // 
            this.buttonWillBringEdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWillBringEdt.Location = new System.Drawing.Point(174, 3);
            this.buttonWillBringEdt.Name = "buttonWillBringEdt";
            this.buttonWillBringEdt.Size = new System.Drawing.Size(81, 23);
            this.buttonWillBringEdt.TabIndex = 2;
            this.buttonWillBringEdt.Text = "Edit";
            this.buttonWillBringEdt.UseVisualStyleBackColor = true;
            // 
            // labelWillBring
            // 
            this.labelWillBring.AutoSize = true;
            this.labelWillBring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWillBring.Location = new System.Drawing.Point(0, 0);
            this.labelWillBring.Name = "labelWillBring";
            this.labelWillBring.Size = new System.Drawing.Size(74, 16);
            this.labelWillBring.TabIndex = 3;
            this.labelWillBring.Text = "Will Bring";
            // 
            // buttonResetFriend
            // 
            this.buttonResetFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetFriend.Location = new System.Drawing.Point(397, 489);
            this.buttonResetFriend.Name = "buttonResetFriend";
            this.buttonResetFriend.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFriend.TabIndex = 7;
            this.buttonResetFriend.Text = "Reset";
            this.buttonResetFriend.UseVisualStyleBackColor = true;
            this.buttonResetFriend.Click += new System.EventHandler(this.buttonResetFriend_Click);
            // 
            // buttonSaveFriend
            // 
            this.buttonSaveFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFriend.Enabled = false;
            this.buttonSaveFriend.Location = new System.Drawing.Point(478, 489);
            this.buttonSaveFriend.Name = "buttonSaveFriend";
            this.buttonSaveFriend.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFriend.TabIndex = 6;
            this.buttonSaveFriend.Text = "Save";
            this.buttonSaveFriend.UseVisualStyleBackColor = true;
            this.buttonSaveFriend.Click += new System.EventHandler(this.buttonSaveFriend_Click);
            // 
            // textBoxFriendName
            // 
            this.textBoxFriendName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFriendName.Location = new System.Drawing.Point(48, 36);
            this.textBoxFriendName.Name = "textBoxFriendName";
            this.textBoxFriendName.Size = new System.Drawing.Size(505, 20);
            this.textBoxFriendName.TabIndex = 5;
            this.textBoxFriendName.TextChanged += new System.EventHandler(this.textBoxFriendName_TextChanged);
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Location = new System.Drawing.Point(10, 39);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(38, 13);
            this.labelFriendName.TabIndex = 4;
            this.labelFriendName.Text = "Name:";
            // 
            // listBoxWillWant
            // 
            this.listBoxWillWant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWillWant.FormattingEnabled = true;
            this.listBoxWillWant.Location = new System.Drawing.Point(3, 51);
            this.listBoxWillWant.Name = "listBoxWillWant";
            this.listBoxWillWant.Size = new System.Drawing.Size(262, 303);
            this.listBoxWillWant.TabIndex = 5;
            // 
            // JasonAndFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 519);
            this.Controls.Add(this.panelFriendInfo);
            this.MinimumSize = new System.Drawing.Size(525, 400);
            this.Name = "JasonAndFriends";
            this.Text = "Jason and his friends";
            this.Load += new System.EventHandler(this.JasonAndFriends_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JasonAndFriends_Closing);
            this.panelFriendInfo.ResumeLayout(false);
            this.panelFriendInfo.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDietary.ResumeLayout(false);
            this.panelDietary.PerformLayout();
            this.panelCanDrink.ResumeLayout(false);
            this.panelCanDrink.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelWillBring.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Button buttonNewFriend;
        private System.Windows.Forms.Button buttonDelFriend;
        private System.Windows.Forms.Panel panelFriendInfo;
        private System.Windows.Forms.TextBox textBoxFriendName;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.ComboBox comboBoxSelFriends;
        private System.Windows.Forms.Button buttonResetFriend;
        private System.Windows.Forms.Button buttonSaveFriend;
        private System.Windows.Forms.RadioButton radioButtonCanDrinkNo;
        private System.Windows.Forms.RadioButton radioButtonCanDrinkYes;
        private System.Windows.Forms.Label labelCanDrink;
        private System.Windows.Forms.Label labelDietary;
        private System.Windows.Forms.RadioButton radioButtonDietaryNo;
        private System.Windows.Forms.RadioButton radioButtonDietaryYes;
        private System.Windows.Forms.Panel panelCanDrink;
        private System.Windows.Forms.Panel panelDietary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWillBring;
        private System.Windows.Forms.Button buttonWillBringEdt;
        private System.Windows.Forms.Button buttonWillBringRem;
        private System.Windows.Forms.Button buttonWillBringNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWillBring;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonWillWantNew;
        private System.Windows.Forms.Button buttonWillWantRem;
        private System.Windows.Forms.Button buttonWillWantEdt;
        private System.Windows.Forms.Label labelWillWant;
        private System.Windows.Forms.ListBox listBoxWillBring;
        private System.Windows.Forms.ListBox listBoxWillWant;
    }
}

