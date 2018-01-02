using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NoteBook
{
	/// <summary>
	/// frmTurn 的摘要说明。
	/// </summary>
	public class frmTurn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labTurn;
		private System.Windows.Forms.TextBox txtTurn;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancle;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTurn()
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
			this.labTurn = new System.Windows.Forms.Label();
			this.txtTurn = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labTurn
			// 
			this.labTurn.Location = new System.Drawing.Point(16, 16);
			this.labTurn.Name = "labTurn";
			this.labTurn.Size = new System.Drawing.Size(80, 24);
			this.labTurn.TabIndex = 0;
			this.labTurn.Text = "要转到的行数";
			this.labTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTurn
			// 
			this.txtTurn.Location = new System.Drawing.Point(104, 16);
			this.txtTurn.Name = "txtTurn";
			this.txtTurn.Size = new System.Drawing.Size(80, 21);
			this.txtTurn.TabIndex = 1;
			this.txtTurn.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(24, 56);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(56, 24);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "确定";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancle.Location = new System.Drawing.Point(120, 56);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(56, 24);
			this.btnCancle.TabIndex = 3;
			this.btnCancle.Text = "取消";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// frmTurn
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 14);
			this.CancelButton = this.btnCancle;
			this.ClientSize = new System.Drawing.Size(208, 94);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtTurn);
			this.Controls.Add(this.labTurn);
			this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTurn";
			this.Text = "转到";
			this.ResumeLayout(false);

		}
		#endregion

//		取消
		private void btnCancle_Click(object sender, System.EventArgs e)
		{
            this.Hide();		
		}

//		确定
		private void btnOk_Click(object sender, System.EventArgs e)
		{	
			frmMain mainForm=(frmMain)this.Owner;
			int maxNum=mainForm.richTextBox.Lines.Length;//输入的文本行总数			
			int selectNo=Int16.Parse(this.txtTurn.Text)-1;//要跳转到的行数，在前一个回车符后
			int findNo=0;  //回车符数
			int findPoint=0;//光标所在位置
			
				if((selectNo+1)<=maxNum)
				{
					while(findNo<selectNo)
					{
						findPoint=mainForm.richTextBox.Text.IndexOf("\n",(findPoint+1));

						findNo+=1;
					}
				
					mainForm.richTextBox .Select((findPoint+1),0);//减去回车符所占的位数
				}
				else
					MessageBox.Show("行数超过范围","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);

				mainForm.Activate();			

		}
	}
}
