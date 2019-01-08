/*
 * Created by SharpDevelop.
 * User: C1-B03
 * Date: 1/8/2019
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OPP_THICUOIKY
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
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.btSave = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
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
			this.toolStrip1.Size = new System.Drawing.Size(590, 25);
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
			this.tsbLine.Size = new System.Drawing.Size(49, 22);
			this.tsbLine.Text = "Line";
			// 
			// tsbTraingle
			// 
			this.tsbTraingle.Checked = true;
			this.tsbTraingle.CheckOnClick = true;
			this.tsbTraingle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbTraingle.Image = ((System.Drawing.Image)(resources.GetObject("tsbTraingle.Image")));
			this.tsbTraingle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTraingle.Name = "tsbTraingle";
			this.tsbTraingle.Size = new System.Drawing.Size(70, 22);
			this.tsbTraingle.Text = "Traingle";
			// 
			// tsbShombus
			// 
			this.tsbShombus.Checked = true;
			this.tsbShombus.CheckOnClick = true;
			this.tsbShombus.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbShombus.Image = ((System.Drawing.Image)(resources.GetObject("tsbShombus.Image")));
			this.tsbShombus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbShombus.Name = "tsbShombus";
			this.tsbShombus.Size = new System.Drawing.Size(77, 22);
			this.tsbShombus.Text = "Shombus";
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.White;
			this.pbDraw.Location = new System.Drawing.Point(10, 34);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(579, 209);
			this.pbDraw.TabIndex = 1;
			this.pbDraw.TabStop = false;
			this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(400, 6);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			// 
			// btLoad
			// 
			this.btLoad.Location = new System.Drawing.Point(492, 8);
			this.btLoad.Name = "btLoad";
			this.btLoad.Size = new System.Drawing.Size(75, 23);
			this.btLoad.TabIndex = 3;
			this.btLoad.Text = "Load";
			this.btLoad.UseVisualStyleBackColor = true;
		
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 249);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.pbDraw);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "OPP-THICUOIKY";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.ToolStripButton tsbShombus;
		private System.Windows.Forms.ToolStripButton tsbTraingle;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
