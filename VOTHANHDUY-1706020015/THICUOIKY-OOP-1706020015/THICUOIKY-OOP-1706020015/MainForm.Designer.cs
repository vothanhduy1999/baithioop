/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace THICUOIKY_OOP_1706020015
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.tsbTraingle = new System.Windows.Forms.ToolStripButton();
			this.tsbShombus = new System.Windows.Forms.ToolStripButton();
			this.btSave = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbLine,
									this.tsbTraingle,
									this.tsbShombus});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(592, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbLine
			// 
			this.tsbLine.Checked = true;
			this.tsbLine.CheckOnClick = true;
			this.tsbLine.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(33, 35);
			this.tsbLine.Text = "Line";
			this.tsbLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbTraingle
			// 
			this.tsbTraingle.Checked = true;
			this.tsbTraingle.CheckOnClick = true;
			this.tsbTraingle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbTraingle.Image = ((System.Drawing.Image)(resources.GetObject("tsbTraingle.Image")));
			this.tsbTraingle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTraingle.Name = "tsbTraingle";
			this.tsbTraingle.Size = new System.Drawing.Size(54, 35);
			this.tsbTraingle.Text = "Traingle";
			this.tsbTraingle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbShombus
			// 
			this.tsbShombus.Checked = true;
			this.tsbShombus.CheckOnClick = true;
			this.tsbShombus.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbShombus.Image = ((System.Drawing.Image)(resources.GetObject("tsbShombus.Image")));
			this.tsbShombus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbShombus.Name = "tsbShombus";
			this.tsbShombus.Size = new System.Drawing.Size(61, 35);
			this.tsbShombus.Text = "Shombus";
			this.tsbShombus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(421, 3);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(69, 25);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			// 
			// btLoad
			// 
			this.btLoad.Location = new System.Drawing.Point(496, 3);
			this.btLoad.Name = "btLoad";
			this.btLoad.Size = new System.Drawing.Size(70, 25);
			this.btLoad.TabIndex = 3;
			this.btLoad.Text = "Load";
			this.btLoad.UseVisualStyleBackColor = true;
			// 
			// pbDraw
			// 
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 38);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(592, 224);
			this.pbDraw.TabIndex = 4;
			this.pbDraw.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 262);
			this.Controls.Add(this.pbDraw);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "THICUOIKY-OOP-1706020015";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.ToolStripButton tsbShombus;
		private System.Windows.Forms.ToolStripButton tsbTraingle;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
