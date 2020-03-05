/*
 * Created by SharpDevelop.
 * User: john_
 * Date: 27/02/2020
 * Time: 7:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PDFdivvyWF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		private void buttonSetCSV_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "csv|*.csv";
			var r = ofd.ShowDialog();
			if (r != DialogResult.Cancel)
				textBoxCsvFileName.Text = ofd.FileName;
		}

		private void buttonSetPdf_Click(object sender, EventArgs e)
		{

			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "pdf|*.pdf";
			var r = ofd.ShowDialog();
			if (r != DialogResult.Cancel)
				textBoxPDFfileName.Text = ofd.FileName;
		}

		void logToText(string message)
		{
			textBoxLog.AppendText(message + Environment.NewLine);
		}

		private void buttonDivvy_Click(object sender, EventArgs e)
		{
			DivvyUpPDF divvy = new DivvyUpPDF();
			divvy.writeLog = logToText;
			var csvLineCount = divvy.loadCSV(textBoxCsvFileName.Text);
			logToText("Loaded " + csvLineCount + " lines");

			bool dowrite = ! checkBoxTestOnly.Checked;

			divvy.processPDF(textBoxPDFfileName.Text,textBoxOutputDirectory.Text,textBoxFileFormat.Text,dowrite);
		}

		private void buttonSetDirectory_Click(object sender, EventArgs e)
		{
			// TODO Try answer 2 - https://stackoverflow.com/questions/11624298/how-to-use-openfiledialog-to-select-a-folder
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			var result = fbd.ShowDialog();
			if (result == DialogResult.OK)
				textBoxOutputDirectory.Text = fbd.SelectedPath;
		}
	}
}
