/*
 * Created by SharpDevelop.
 * User: john_
 * Date: 27/02/2020
 * Time: 7:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PDFdivvyWF
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCsvFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSetCSV = new System.Windows.Forms.Button();
            this.buttonSetPdf = new System.Windows.Forms.Button();
            this.textBoxPDFfileName = new System.Windows.Forms.TextBox();
            this.buttonSetDirectory = new System.Windows.Forms.Button();
            this.textBoxOutputDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDivvyUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFileFormat = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.checkBoxTestOnly = new System.Windows.Forms.CheckBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divides a PDF as per a CSV file";
            // 
            // textBoxCsvFileName
            // 
            this.textBoxCsvFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCsvFileName.Location = new System.Drawing.Point(12, 92);
            this.textBoxCsvFileName.Name = "textBoxCsvFileName";
            this.textBoxCsvFileName.Size = new System.Drawing.Size(659, 22);
            this.textBoxCsvFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CSV File";
            // 
            // buttonSetCSV
            // 
            this.buttonSetCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetCSV.Location = new System.Drawing.Point(708, 91);
            this.buttonSetCSV.Name = "buttonSetCSV";
            this.buttonSetCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonSetCSV.TabIndex = 3;
            this.buttonSetCSV.Text = "Set";
            this.buttonSetCSV.UseVisualStyleBackColor = true;
            this.buttonSetCSV.Click += new System.EventHandler(this.buttonSetCSV_Click);
            // 
            // buttonSetPdf
            // 
            this.buttonSetPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetPdf.Location = new System.Drawing.Point(713, 162);
            this.buttonSetPdf.Name = "buttonSetPdf";
            this.buttonSetPdf.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPdf.TabIndex = 5;
            this.buttonSetPdf.Text = "Set";
            this.buttonSetPdf.UseVisualStyleBackColor = true;
            this.buttonSetPdf.Click += new System.EventHandler(this.buttonSetPdf_Click);
            // 
            // textBoxPDFfileName
            // 
            this.textBoxPDFfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPDFfileName.Location = new System.Drawing.Point(12, 163);
            this.textBoxPDFfileName.Name = "textBoxPDFfileName";
            this.textBoxPDFfileName.Size = new System.Drawing.Size(659, 22);
            this.textBoxPDFfileName.TabIndex = 4;
            // 
            // buttonSetDirectory
            // 
            this.buttonSetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetDirectory.Location = new System.Drawing.Point(713, 231);
            this.buttonSetDirectory.Name = "buttonSetDirectory";
            this.buttonSetDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonSetDirectory.TabIndex = 7;
            this.buttonSetDirectory.Text = "Set";
            this.buttonSetDirectory.UseVisualStyleBackColor = true;
            this.buttonSetDirectory.Click += new System.EventHandler(this.buttonSetDirectory_Click);
            // 
            // textBoxOutputDirectory
            // 
            this.textBoxOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputDirectory.Location = new System.Drawing.Point(12, 232);
            this.textBoxOutputDirectory.Name = "textBoxOutputDirectory";
            this.textBoxOutputDirectory.Size = new System.Drawing.Size(659, 22);
            this.textBoxOutputDirectory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "PDF File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output Directory";
            // 
            // buttonDivvyUp
            // 
            this.buttonDivvyUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.buttonDivvyUp, "Split the PDF");
            this.buttonDivvyUp.Location = new System.Drawing.Point(713, 310);
            this.buttonDivvyUp.Name = "buttonDivvyUp";
            this.helpProvider.SetShowHelp(this.buttonDivvyUp, true);
            this.buttonDivvyUp.Size = new System.Drawing.Size(75, 23);
            this.buttonDivvyUp.TabIndex = 10;
            this.buttonDivvyUp.Text = "Divvy";
            this.buttonDivvyUp.UseVisualStyleBackColor = true;
            this.buttonDivvyUp.Click += new System.EventHandler(this.buttonDivvy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Format";
            // 
            // textBoxFileFormat
            // 
            this.textBoxFileFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileFormat.Location = new System.Drawing.Point(12, 310);
            this.textBoxFileFormat.Name = "textBoxFileFormat";
            this.textBoxFileFormat.Size = new System.Drawing.Size(659, 22);
            this.textBoxFileFormat.TabIndex = 11;
            this.textBoxFileFormat.Text = "{1}.pdf";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(12, 380);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(796, 104);
            this.textBoxLog.TabIndex = 14;
            // 
            // checkBoxTestOnly
            // 
            this.checkBoxTestOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTestOnly.AutoSize = true;
            this.helpProvider.SetHelpString(this.checkBoxTestOnly, "When checked does not write new PDF files but checks files and formats");
            this.checkBoxTestOnly.Location = new System.Drawing.Point(715, 350);
            this.checkBoxTestOnly.Name = "checkBoxTestOnly";
            this.helpProvider.SetShowHelp(this.checkBoxTestOnly, true);
            this.checkBoxTestOnly.Size = new System.Drawing.Size(88, 21);
            this.checkBoxTestOnly.TabIndex = 15;
            this.checkBoxTestOnly.Text = "Test only";
            this.checkBoxTestOnly.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 511);
            this.Controls.Add(this.checkBoxTestOnly);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileFormat);
            this.Controls.Add(this.buttonDivvyUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSetDirectory);
            this.Controls.Add(this.textBoxOutputDirectory);
            this.Controls.Add(this.buttonSetPdf);
            this.Controls.Add(this.textBoxPDFfileName);
            this.Controls.Add(this.buttonSetCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCsvFileName);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "PDF Divvy";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCsvFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSetCSV;
		private System.Windows.Forms.Button buttonSetPdf;
		private System.Windows.Forms.TextBox textBoxPDFfileName;
		private System.Windows.Forms.Button buttonSetDirectory;
		private System.Windows.Forms.TextBox textBoxOutputDirectory;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDivvyUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFileFormat;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.CheckBox checkBoxTestOnly;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}
