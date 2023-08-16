namespace DataPacketViewer
{
    partial class CodeDecodeForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodeGroupBox = new System.Windows.Forms.GroupBox();
            this.codedDataPacketsLabel = new System.Windows.Forms.Label();
            this.codedDataPacketsTextBox = new System.Windows.Forms.TextBox();
            this.payloadDataBytesLabel = new System.Windows.Forms.Label();
            this.commandByteLabel = new System.Windows.Forms.Label();
            this.starterByte2Label = new System.Windows.Forms.Label();
            this.codeButton = new System.Windows.Forms.Button();
            this.payloadDataBytesTextBox = new System.Windows.Forms.TextBox();
            this.commandByteTextBox = new System.Windows.Forms.TextBox();
            this.starterByte2TextBox = new System.Windows.Forms.TextBox();
            this.starterByte1Label = new System.Windows.Forms.Label();
            this.starterByte1TextBox = new System.Windows.Forms.TextBox();
            this.decodeGroupBox = new System.Windows.Forms.GroupBox();
            this.decodedDataPacketsLabel = new System.Windows.Forms.Label();
            this.decodedDataPacketsListView = new System.Windows.Forms.ListView();
            this.dataPacketLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.dataPacketTextBox = new System.Windows.Forms.TextBox();
            this.CodeGroupBox.SuspendLayout();
            this.decodeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeGroupBox
            // 
            this.CodeGroupBox.Controls.Add(this.codedDataPacketsLabel);
            this.CodeGroupBox.Controls.Add(this.codedDataPacketsTextBox);
            this.CodeGroupBox.Controls.Add(this.payloadDataBytesLabel);
            this.CodeGroupBox.Controls.Add(this.commandByteLabel);
            this.CodeGroupBox.Controls.Add(this.starterByte2Label);
            this.CodeGroupBox.Controls.Add(this.codeButton);
            this.CodeGroupBox.Controls.Add(this.payloadDataBytesTextBox);
            this.CodeGroupBox.Controls.Add(this.commandByteTextBox);
            this.CodeGroupBox.Controls.Add(this.starterByte2TextBox);
            this.CodeGroupBox.Controls.Add(this.starterByte1Label);
            this.CodeGroupBox.Controls.Add(this.starterByte1TextBox);
            this.CodeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CodeGroupBox.Name = "CodeGroupBox";
            this.CodeGroupBox.Size = new System.Drawing.Size(760, 245);
            this.CodeGroupBox.TabIndex = 0;
            this.CodeGroupBox.TabStop = false;
            this.CodeGroupBox.Text = "Code";
            // 
            // codedDataPacketsLabel
            // 
            this.codedDataPacketsLabel.AutoSize = true;
            this.codedDataPacketsLabel.Location = new System.Drawing.Point(6, 71);
            this.codedDataPacketsLabel.Name = "codedDataPacketsLabel";
            this.codedDataPacketsLabel.Size = new System.Drawing.Size(106, 13);
            this.codedDataPacketsLabel.TabIndex = 10;
            this.codedDataPacketsLabel.Text = "Coded Data Packets";
            // 
            // codedDataPacketsTextBox
            // 
            this.codedDataPacketsTextBox.Location = new System.Drawing.Point(6, 86);
            this.codedDataPacketsTextBox.Multiline = true;
            this.codedDataPacketsTextBox.Name = "codedDataPacketsTextBox";
            this.codedDataPacketsTextBox.Size = new System.Drawing.Size(748, 152);
            this.codedDataPacketsTextBox.TabIndex = 9;
            // 
            // payloadDataBytesLabel
            // 
            this.payloadDataBytesLabel.AutoSize = true;
            this.payloadDataBytesLabel.Location = new System.Drawing.Point(240, 27);
            this.payloadDataBytesLabel.Name = "payloadDataBytesLabel";
            this.payloadDataBytesLabel.Size = new System.Drawing.Size(100, 13);
            this.payloadDataBytesLabel.TabIndex = 8;
            this.payloadDataBytesLabel.Text = "Payload Data Bytes";
            // 
            // commandByteLabel
            // 
            this.commandByteLabel.AutoSize = true;
            this.commandByteLabel.Location = new System.Drawing.Point(156, 26);
            this.commandByteLabel.Name = "commandByteLabel";
            this.commandByteLabel.Size = new System.Drawing.Size(78, 13);
            this.commandByteLabel.TabIndex = 7;
            this.commandByteLabel.Text = "Command Byte";
            // 
            // starterByte2Label
            // 
            this.starterByte2Label.AutoSize = true;
            this.starterByte2Label.Location = new System.Drawing.Point(81, 26);
            this.starterByte2Label.Name = "starterByte2Label";
            this.starterByte2Label.Size = new System.Drawing.Size(71, 13);
            this.starterByte2Label.TabIndex = 6;
            this.starterByte2Label.Text = "Starter Byte 2";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(645, 38);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(109, 23);
            this.codeButton.TabIndex = 5;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // payloadDataBytesTextBox
            // 
            this.payloadDataBytesTextBox.Location = new System.Drawing.Point(241, 41);
            this.payloadDataBytesTextBox.Name = "payloadDataBytesTextBox";
            this.payloadDataBytesTextBox.Size = new System.Drawing.Size(398, 20);
            this.payloadDataBytesTextBox.TabIndex = 4;
            // 
            // commandByteTextBox
            // 
            this.commandByteTextBox.Location = new System.Drawing.Point(157, 41);
            this.commandByteTextBox.Name = "commandByteTextBox";
            this.commandByteTextBox.Size = new System.Drawing.Size(78, 20);
            this.commandByteTextBox.TabIndex = 3;
            // 
            // starterByte2TextBox
            // 
            this.starterByte2TextBox.Location = new System.Drawing.Point(83, 41);
            this.starterByte2TextBox.Name = "starterByte2TextBox";
            this.starterByte2TextBox.Size = new System.Drawing.Size(68, 20);
            this.starterByte2TextBox.TabIndex = 2;
            // 
            // starterByte1Label
            // 
            this.starterByte1Label.AutoSize = true;
            this.starterByte1Label.Location = new System.Drawing.Point(5, 26);
            this.starterByte1Label.Name = "starterByte1Label";
            this.starterByte1Label.Size = new System.Drawing.Size(71, 13);
            this.starterByte1Label.TabIndex = 1;
            this.starterByte1Label.Text = "Starter Byte 1";
            // 
            // starterByte1TextBox
            // 
            this.starterByte1TextBox.Location = new System.Drawing.Point(6, 41);
            this.starterByte1TextBox.Name = "starterByte1TextBox";
            this.starterByte1TextBox.Size = new System.Drawing.Size(71, 20);
            this.starterByte1TextBox.TabIndex = 0;
            // 
            // decodeGroupBox
            // 
            this.decodeGroupBox.Controls.Add(this.decodedDataPacketsLabel);
            this.decodeGroupBox.Controls.Add(this.decodedDataPacketsListView);
            this.decodeGroupBox.Controls.Add(this.dataPacketLabel);
            this.decodeGroupBox.Controls.Add(this.decodeButton);
            this.decodeGroupBox.Controls.Add(this.dataPacketTextBox);
            this.decodeGroupBox.Location = new System.Drawing.Point(12, 263);
            this.decodeGroupBox.Name = "decodeGroupBox";
            this.decodeGroupBox.Size = new System.Drawing.Size(760, 286);
            this.decodeGroupBox.TabIndex = 1;
            this.decodeGroupBox.TabStop = false;
            this.decodeGroupBox.Text = "Decode";
            // 
            // decodedDataPacketsLabel
            // 
            this.decodedDataPacketsLabel.AutoSize = true;
            this.decodedDataPacketsLabel.Location = new System.Drawing.Point(5, 74);
            this.decodedDataPacketsLabel.Name = "decodedDataPacketsLabel";
            this.decodedDataPacketsLabel.Size = new System.Drawing.Size(119, 13);
            this.decodedDataPacketsLabel.TabIndex = 4;
            this.decodedDataPacketsLabel.Text = "Decoded Data Packets";
            // 
            // decodedDataPacketsListView
            // 
            this.decodedDataPacketsListView.FullRowSelect = true;
            this.decodedDataPacketsListView.HideSelection = false;
            this.decodedDataPacketsListView.Location = new System.Drawing.Point(6, 90);
            this.decodedDataPacketsListView.Name = "decodedDataPacketsListView";
            this.decodedDataPacketsListView.Size = new System.Drawing.Size(747, 190);
            this.decodedDataPacketsListView.TabIndex = 3;
            this.decodedDataPacketsListView.UseCompatibleStateImageBehavior = false;
            // 
            // dataPacketLabel
            // 
            this.dataPacketLabel.AutoSize = true;
            this.dataPacketLabel.Location = new System.Drawing.Point(6, 26);
            this.dataPacketLabel.Name = "dataPacketLabel";
            this.dataPacketLabel.Size = new System.Drawing.Size(67, 13);
            this.dataPacketLabel.TabIndex = 2;
            this.dataPacketLabel.Text = "Data Packet";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(645, 37);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(108, 23);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // dataPacketTextBox
            // 
            this.dataPacketTextBox.Location = new System.Drawing.Point(6, 41);
            this.dataPacketTextBox.Name = "dataPacketTextBox";
            this.dataPacketTextBox.Size = new System.Drawing.Size(633, 20);
            this.dataPacketTextBox.TabIndex = 0;
            // 
            // CodeDecodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.decodeGroupBox);
            this.Controls.Add(this.CodeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CodeDecodeForm";
            this.Text = "Data Packets - Code and Decode";
            this.CodeGroupBox.ResumeLayout(false);
            this.CodeGroupBox.PerformLayout();
            this.decodeGroupBox.ResumeLayout(false);
            this.decodeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CodeGroupBox;
        private System.Windows.Forms.GroupBox decodeGroupBox;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.TextBox payloadDataBytesTextBox;
        private System.Windows.Forms.TextBox commandByteTextBox;
        private System.Windows.Forms.TextBox starterByte2TextBox;
        private System.Windows.Forms.Label starterByte1Label;
        private System.Windows.Forms.TextBox starterByte1TextBox;
        private System.Windows.Forms.Label codedDataPacketsLabel;
        private System.Windows.Forms.TextBox codedDataPacketsTextBox;
        private System.Windows.Forms.Label payloadDataBytesLabel;
        private System.Windows.Forms.Label commandByteLabel;
        private System.Windows.Forms.Label starterByte2Label;
        private System.Windows.Forms.ListView decodedDataPacketsListView;
        private System.Windows.Forms.Label dataPacketLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox dataPacketTextBox;
        private System.Windows.Forms.Label decodedDataPacketsLabel;
    }
}

