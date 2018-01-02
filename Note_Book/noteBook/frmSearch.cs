using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NoteBook
{
	/// <summary>
	/// frmSearch 的摘要说明。
	/// </summary>
	public class frmSearch : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labelPrompt;
		public  System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.TextBox txtContent;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSearch()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.labelPrompt = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelPrompt
			// 
			this.labelPrompt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.labelPrompt.Location = new System.Drawing.Point(16, 24);
			this.labelPrompt.Name = "labelPrompt";
			this.labelPrompt.Size = new System.Drawing.Size(128, 16);
			this.labelPrompt.TabIndex = 0;
			this.labelPrompt.Text = "输入要查找的内容";
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(144, 24);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(160, 21);
			this.txtContent.TabIndex = 1;
			this.txtContent.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnSearch.Location = new System.Drawing.Point(16, 72);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(96, 32);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "查找下一个";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnCancle.Location = new System.Drawing.Point(232, 72);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(72, 32);
			this.btnCancle.TabIndex = 3;
			this.btnCancle.Text = "取消";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// frmSearch
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.btnCancle;
			this.ClientSize = new System.Drawing.Size(328, 126);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.labelPrompt);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch";
			this.Text = "查找";
			this.ResumeLayout(false);

		}
		#endregion

//		取消按钮
		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

//		查找按钮
		public int searchPoint=0; //设在这，是因为设在内部，接连查询调用form3都会重新赋值，与原意不符
		public void btnSearch_Click(object sender, System.EventArgs e)
		{
					
			if(txtContent.Text!="")
			{
				frmMain mainForm=(frmMain)this.Owner;	
				if(mainForm.richTextBox.Text!="")
				{

					if((searchPoint=mainForm.richTextBox.Text.IndexOf(txtContent.Text,searchPoint))==-1)
					{
						MessageBox.Show("已到文本末尾，没有找到","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
						searchPoint=0;
					}
					else
					{
						mainForm.richTextBox .Select(searchPoint,txtContent.Text.Length);
						searchPoint=searchPoint+txtContent.Text.Length;
						mainForm.Activate();
					}

				}
				else
					MessageBox.Show("无文本，无法查找","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("要查找的内容不能为空，请输入要查找的内容！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
	}
}
