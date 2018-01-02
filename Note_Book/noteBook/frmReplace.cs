using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NoteBook
{
	/// <summary>
	/// frmReplace 的摘要说明。
	/// </summary>
	public class frmReplace : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labSearch;
		private System.Windows.Forms.Label labReplace;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtReplace;
		private System.Windows.Forms.Button btnAll;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmReplace()
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
			this.labSearch = new System.Windows.Forms.Label();
			this.labReplace = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtReplace = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnReplace = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labSearch
			// 
			this.labSearch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.labSearch.Location = new System.Drawing.Point(16, 16);
			this.labSearch.Name = "labSearch";
			this.labSearch.Size = new System.Drawing.Size(96, 24);
			this.labSearch.TabIndex = 0;
			this.labSearch.Text = "要查找的内容";
			this.labSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labReplace
			// 
			this.labReplace.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.labReplace.Location = new System.Drawing.Point(272, 16);
			this.labReplace.Name = "labReplace";
			this.labReplace.Size = new System.Drawing.Size(96, 24);
			this.labReplace.TabIndex = 1;
			this.labReplace.Text = "要替换的内容";
			this.labReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(112, 16);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(120, 21);
			this.txtContent.TabIndex = 2;
			this.txtContent.Text = "";
			// 
			// txtReplace
			// 
			this.txtReplace.Location = new System.Drawing.Point(368, 16);
			this.txtReplace.Name = "txtReplace";
			this.txtReplace.Size = new System.Drawing.Size(120, 21);
			this.txtReplace.TabIndex = 3;
			this.txtReplace.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnSearch.Location = new System.Drawing.Point(24, 72);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 32);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "查找";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnReplace
			// 
			this.btnReplace.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnReplace.Location = new System.Drawing.Point(149, 72);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(80, 32);
			this.btnReplace.TabIndex = 5;
			this.btnReplace.Text = "替换";
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnCancle.Location = new System.Drawing.Point(399, 72);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(80, 32);
			this.btnCancle.TabIndex = 6;
			this.btnCancle.Text = "取消";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnAll
			// 
			this.btnAll.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btnAll.Location = new System.Drawing.Point(274, 72);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(80, 32);
			this.btnAll.TabIndex = 7;
			this.btnAll.Text = "全部替换";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// frmReplace
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(504, 134);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnReplace);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtReplace);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.labReplace);
			this.Controls.Add(this.labSearch);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmReplace";
			this.Text = "替换";
			this.ResumeLayout(false);

		}
		#endregion

//		取消
		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

//		查找
		public int searchPoint=0;
		private void btnSearch_Click(object sender, System.EventArgs e)
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

//		替换
		public int findPoint=0; 
		private void btnReplace_Click(object sender, System.EventArgs e)
		{
			frmMain mainForm=(frmMain)this.Owner;
			if(txtContent.Text!=""&&txtReplace.Text!="")
			{
				if(mainForm.richTextBox.Text!="")
				{
					if((findPoint=mainForm.richTextBox.Text.IndexOf(txtContent.Text,findPoint))==-1)
					{
						MessageBox.Show("已到文本末尾，没有要查找和替换的内容","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
						findPoint=0;
					}
					else
					{
						mainForm.richTextBox .Select(findPoint,txtContent.Text.Length);
						mainForm.richTextBox.SelectedText=txtReplace.Text;
						findPoint=findPoint+txtContent.Text.Length;
						mainForm.Activate();
					}
				}
				else
					MessageBox.Show("无文本，无法查找和替换","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("要查找和替换的内容不能为空，请输入要查找和替换的内容！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						
		}

//		全部替换
		private void btnAll_Click(object sender, System.EventArgs e)
		{
			frmMain mainForm=(frmMain)this.Owner;
			while((findPoint=mainForm.richTextBox.Text.IndexOf(txtContent.Text,findPoint))!=-1)
			{
				mainForm.richTextBox .Select(findPoint,txtContent.Text.Length);
				mainForm.richTextBox.SelectedText=txtReplace.Text;
				findPoint=findPoint+txtContent.Text.Length;
			}
			mainForm.Activate();
		}
	}
}
