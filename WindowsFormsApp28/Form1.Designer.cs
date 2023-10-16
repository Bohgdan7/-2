using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace WindowsFormsApp28
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textResult = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 100);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(273, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 9);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 43);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 100);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "55 + 12";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.textResult);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 43);
            this.panel5.TabIndex = 2;
            // 
            // textResult
            // 
            this.textResult.AutoSize = true;
            this.textResult.BackColor = System.Drawing.SystemColors.GrayText;
            this.textResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textResult.Location = new System.Drawing.Point(254, 3);
            this.textResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(50, 13);
            this.textResult.TabIndex = 3;
            this.textResult.Text = "55 + 12";
            this.textResult.Click += new System.EventHandler(this.textResult_Click);
            // 
            // O
            // 
            this.O.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.O.FlatAppearance.BorderSize = 0;
            this.O.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.O.Location = new System.Drawing.Point(85, 417);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(56, 43);
            this.O.TabIndex = 4;
            this.O.Text = "0";
            this.O.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(85, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(8, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "+/-";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(164, 418);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 46);
            this.button6.TabIndex = 8;
            this.button6.Text = ",";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(240, 418);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 43);
            this.button7.TabIndex = 9;
            this.button7.Text = "=";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(240, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 43);
            this.button8.TabIndex = 10;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(240, 290);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 42);
            this.button9.TabIndex = 11;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.Location = new System.Drawing.Point(240, 231);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 42);
            this.button10.TabIndex = 12;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.Location = new System.Drawing.Point(72, 180);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 34);
            this.button11.TabIndex = 13;
            this.button11.Text = "X^2";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.CausesValidation = false;
            this.button12.Location = new System.Drawing.Point(240, 178);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 38);
            this.button12.TabIndex = 14;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button13.Location = new System.Drawing.Point(240, 143);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(62, 29);
            this.button13.TabIndex = 15;
            this.button13.Text = "<-";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button14.Location = new System.Drawing.Point(151, 139);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(69, 37);
            this.button14.TabIndex = 16;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button15.Location = new System.Drawing.Point(72, 139);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 31);
            this.button15.TabIndex = 17;
            this.button15.Text = "%";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button16.Location = new System.Drawing.Point(0, 139);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 33);
            this.button16.TabIndex = 18;
            this.button16.Text = "1/x";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button17.Location = new System.Drawing.Point(151, 182);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 34);
            this.button17.TabIndex = 19;
            this.button17.Text = "/^";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button18.Location = new System.Drawing.Point(-9, 182);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 33);
            this.button18.TabIndex = 20;
            this.button18.Text = "CE";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button19.Location = new System.Drawing.Point(167, 234);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(64, 37);
            this.button19.TabIndex = 21;
            this.button19.Text = "9";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button20.Location = new System.Drawing.Point(85, 236);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(64, 37);
            this.button20.TabIndex = 22;
            this.button20.Text = "8";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button21.Location = new System.Drawing.Point(0, 240);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(62, 33);
            this.button21.TabIndex = 23;
            this.button21.Text = "7";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click_1);
            // 
            // button22
            // 
            this.button22.AutoSize = true;
            this.button22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button22.CausesValidation = false;
            this.button22.Location = new System.Drawing.Point(164, 290);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(67, 44);
            this.button22.TabIndex = 24;
            this.button22.Text = "6";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button23.Location = new System.Drawing.Point(85, 290);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 42);
            this.button23.TabIndex = 25;
            this.button23.Text = "5";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button24.Location = new System.Drawing.Point(0, 290);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 42);
            this.button24.TabIndex = 26;
            this.button24.Text = "4";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button25.Location = new System.Drawing.Point(164, 347);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(56, 47);
            this.button25.TabIndex = 27;
            this.button25.Text = "3";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp28.Properties.Resources._5545af01681a3a1b1dee5b024aaa5507;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 470);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.O);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<EventHandler>.Default.Equals(button21_Click, form.button21_Click);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override object InitializeLifetimeService()
        {
            return base.InitializeLifetimeService();
        }

        public override ObjRef CreateObjRef(Type requestedType)
        {
            return base.CreateObjRef(requestedType);
        }

        protected override object GetService(Type service)
        {
            return base.GetService(service);
        }

        protected override AccessibleObject GetAccessibilityObjectById(int objectId)
        {
            return base.GetAccessibilityObjectById(objectId);
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return base.GetPreferredSize(proposedSize);
        }

        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return base.CreateAccessibilityInstance();
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();
        }

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        protected override bool IsInputChar(char charCode)
        {
            return base.IsInputChar(charCode);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData);
        }

        protected override void NotifyInvalidate(Rectangle invalidatedArea)
        {
            base.NotifyInvalidate(invalidatedArea);
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
        }

        protected override void OnCausesValidationChanged(EventArgs e)
        {
            base.OnCausesValidationChanged(e);
        }

        protected override void OnContextMenuChanged(EventArgs e)
        {
            base.OnContextMenuChanged(e);
        }

        protected override void OnContextMenuStripChanged(EventArgs e)
        {
            base.OnContextMenuStripChanged(e);
        }

        protected override void OnCursorChanged(EventArgs e)
        {
            base.OnCursorChanged(e);
        }

        protected override void OnDockChanged(EventArgs e)
        {
            base.OnDockChanged(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
        }

        protected override void OnNotifyMessage(Message m)
        {
            base.OnNotifyMessage(m);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
        }

        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            base.OnParentBackgroundImageChanged(e);
        }

        protected override void OnParentBindingContextChanged(EventArgs e)
        {
            base.OnParentBindingContextChanged(e);
        }

        protected override void OnParentCursorChanged(EventArgs e)
        {
            base.OnParentCursorChanged(e);
        }

        protected override void OnParentEnabledChanged(EventArgs e)
        {
            base.OnParentEnabledChanged(e);
        }

        protected override void OnParentFontChanged(EventArgs e)
        {
            base.OnParentFontChanged(e);
        }

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            base.OnParentForeColorChanged(e);
        }

        protected override void OnParentRightToLeftChanged(EventArgs e)
        {
            base.OnParentRightToLeftChanged(e);
        }

        protected override void OnParentVisibleChanged(EventArgs e)
        {
            base.OnParentVisibleChanged(e);
        }

        protected override void OnPrint(PaintEventArgs e)
        {
            base.OnPrint(e);
        }

        protected override void OnTabIndexChanged(EventArgs e)
        {
            base.OnTabIndexChanged(e);
        }

        protected override void OnTabStopChanged(EventArgs e)
        {
            base.OnTabStopChanged(e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnHelpRequested(HelpEventArgs hevent)
        {
            base.OnHelpRequested(hevent);
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnMarginChanged(EventArgs e)
        {
            base.OnMarginChanged(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnDpiChangedBeforeParent(EventArgs e)
        {
            base.OnDpiChangedBeforeParent(e);
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
        }

        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent)
        {
            base.OnQueryContinueDrag(qcdevent);
        }

        protected override void OnRegionChanged(EventArgs e)
        {
            base.OnRegionChanged(e);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnChangeUICues(UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
        }

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            return base.PreProcessMessage(ref msg);
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            return base.ProcessKeyEventArgs(ref m);
        }

        protected override bool ProcessKeyMessage(ref Message m)
        {
            return base.ProcessKeyMessage(ref m);
        }

        public override void ResetBackColor()
        {
            base.ResetBackColor();
        }

        public override void ResetCursor()
        {
            base.ResetCursor();
        }

        public override void ResetFont()
        {
            base.ResetFont();
        }

        public override void ResetForeColor()
        {
            base.ResetForeColor();
        }

        public override void ResetRightToLeft()
        {
            base.ResetRightToLeft();
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        public override void ResetText()
        {
            base.ResetText();
        }

        protected override Size SizeFromClientSize(Size clientSize)
        {
            return base.SizeFromClientSize(clientSize);
        }

        protected override void OnImeModeChanged(EventArgs e)
        {
            base.OnImeModeChanged(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return base.ScrollToControl(activeControl);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
        }

        protected override void OnAutoValidateChanged(EventArgs e)
        {
            base.OnAutoValidateChanged(e);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(value);
        }

        protected override void AdjustFormScrollbars(bool displayScrollbars)
        {
            base.AdjustFormScrollbars(displayScrollbars);
        }

        protected override Control.ControlCollection CreateControlsInstance()
        {
            return base.CreateControlsInstance();
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        protected override void DefWndProc(ref Message m)
        {
            base.DefWndProc(ref m);
        }

        protected override bool ProcessMnemonic(char charCode)
        {
            return base.ProcessMnemonic(charCode);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
        }

        protected override void OnBackgroundImageLayoutChanged(EventArgs e)
        {
            base.OnBackgroundImageLayoutChanged(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        protected override void OnHelpButtonClicked(CancelEventArgs e)
        {
            base.OnHelpButtonClicked(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnMaximizedBoundsChanged(EventArgs e)
        {
            base.OnMaximizedBoundsChanged(e);
        }

        protected override void OnMaximumSizeChanged(EventArgs e)
        {
            base.OnMaximumSizeChanged(e);
        }

        protected override void OnMinimumSizeChanged(EventArgs e)
        {
            base.OnMinimumSizeChanged(e);
        }

        protected override void OnInputLanguageChanged(InputLanguageChangedEventArgs e)
        {
            base.OnInputLanguageChanged(e);
        }

        protected override void OnInputLanguageChanging(InputLanguageChangingEventArgs e)
        {
            base.OnInputLanguageChanging(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
        }

        protected override void OnMenuStart(EventArgs e)
        {
            base.OnMenuStart(e);
        }

        protected override void OnMenuComplete(EventArgs e)
        {
            base.OnMenuComplete(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnDpiChanged(DpiChangedEventArgs e)
        {
            base.OnDpiChanged(e);
        }

        protected override bool OnGetDpiScaledSize(int deviceDpiOld, int deviceDpiNew, ref Size desiredSize)
        {
            return base.OnGetDpiScaledSize(deviceDpiOld, deviceDpiNew, ref desiredSize);
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            base.OnRightToLeftLayoutChanged(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessDialogChar(char charCode)
        {
            return base.ProcessDialogChar(charCode);
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            return base.ProcessKeyPreview(ref m);
        }

        protected override bool ProcessTabKey(bool forward)
        {
            return base.ProcessTabKey(forward);
        }

        protected override void Select(bool directed, bool forward)
        {
            base.Select(directed, forward);
        }

        protected override void ScaleCore(float x, float y)
        {
            base.ScaleCore(x, y);
        }

        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
        {
            return base.GetScaledBounds(bounds, factor, specified);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
        }

        protected override void SetClientSizeCore(int x, int y)
        {
            base.SetClientSizeCore(x, y);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void UpdateDefaultButton()
        {
            base.UpdateDefaultButton();
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
        }

        protected override void OnStyleChanged(EventArgs e)
        {
            base.OnStyleChanged(e);
        }

        public override bool ValidateChildren()
        {
            return base.ValidateChildren();
        }

        public override bool ValidateChildren(ValidationConstraints validationConstraints)
        {
            return base.ValidateChildren(validationConstraints);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label textResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private EventHandler button5_Click;
        private EventHandler button21_Click;
        private EventHandler button21_Click_1;

        public EventHandler O_Click { get; private set; }
        public override bool AllowDrop { get => base.AllowDrop; set => base.AllowDrop = value; }
        public override AnchorStyles Anchor { get => base.Anchor; set => base.Anchor = value; }
        public override Point AutoScrollOffset { get => base.AutoScrollOffset; set => base.AutoScrollOffset = value; }

        public override LayoutEngine LayoutEngine => base.LayoutEngine;

        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }

        protected override bool CanRaiseEvents => base.CanRaiseEvents;

        public override ContextMenu ContextMenu { get => base.ContextMenu; set => base.ContextMenu = value; }
        public override ContextMenuStrip ContextMenuStrip { get => base.ContextMenuStrip; set => base.ContextMenuStrip = value; }
        public override Cursor Cursor { get => base.Cursor; set => base.Cursor = value; }

        protected override Cursor DefaultCursor => base.DefaultCursor;

        protected override Padding DefaultMargin => base.DefaultMargin;

        protected override Size DefaultMaximumSize => base.DefaultMaximumSize;

        protected override Size DefaultMinimumSize => base.DefaultMinimumSize;

        protected override Padding DefaultPadding => base.DefaultPadding;

        public override DockStyle Dock { get => base.Dock; set => base.Dock = value; }
        protected override bool DoubleBuffered { get => base.DoubleBuffered; set => base.DoubleBuffered = value; }

        public override bool Focused => base.Focused;

        public override Font Font { get => base.Font; set => base.Font = value; }
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        public override RightToLeft RightToLeft { get => base.RightToLeft; set => base.RightToLeft = value; }

        protected override bool ScaleChildren => base.ScaleChildren;

        public override ISite Site { get => base.Site; set => base.Site = value; }

        protected override bool ShowKeyboardCues => base.ShowKeyboardCues;

        protected override bool ShowFocusCues => base.ShowFocusCues;

        protected override ImeMode ImeModeBase { get => base.ImeModeBase; set => base.ImeModeBase = value; }

        public override Rectangle DisplayRectangle => base.DisplayRectangle;

        public override BindingContext BindingContext { get => base.BindingContext; set => base.BindingContext = value; }

        protected override bool CanEnableIme => base.CanEnableIme;

        public override Size AutoScaleBaseSize { get => base.AutoScaleBaseSize; set => base.AutoScaleBaseSize = value; }
        public override bool AutoScroll { get => base.AutoScroll; set => base.AutoScroll = value; }
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
        public override AutoValidate AutoValidate { get => base.AutoValidate; set => base.AutoValidate = value; }
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }

        protected override CreateParams CreateParams => base.CreateParams;

        protected override ImeMode DefaultImeMode => base.DefaultImeMode;

        protected override Size DefaultSize => base.DefaultSize;

        public override Size MaximumSize { get => base.MaximumSize; set => base.MaximumSize = value; }
        public override Size MinimumSize { get => base.MinimumSize; set => base.MinimumSize = value; }
        public override bool RightToLeftLayout { get => base.RightToLeftLayout; set => base.RightToLeftLayout = value; }

        protected override bool ShowWithoutActivation => base.ShowWithoutActivation;

        public override string Text { get => base.Text; set => base.Text = value; }
    }
}

