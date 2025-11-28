
namespace zCalcWorkTime
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_TimeTx = new System.Windows.Forms.TextBox();
            this.TextBox_TimeRx = new System.Windows.Forms.TextBox();
            this.TextBox_TimeWork = new System.Windows.Forms.TextBox();
            this.TextBox_CurrentWait = new System.Windows.Forms.TextBox();
            this.TextBox_CurrentTx = new System.Windows.Forms.TextBox();
            this.TextBox_CurrentRx = new System.Windows.Forms.TextBox();
            this.TextBox_CurrentWork = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_TimeWait = new System.Windows.Forms.TextBox();
            this.TextBox_CurrentSleep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_TxWithACK = new System.Windows.Forms.TextBox();
            this.TextBox_BatteryCapacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox_TimeDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_TimeMonth = new System.Windows.Forms.TextBox();
            this.TextBox_TimeYears = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBox_TxWithoutACK = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBox_Current = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBox_ErrorPercent = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBox_TimeHours = new System.Windows.Forms.TextBox();
            this.TextBox_RxTimeout = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время, мс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ток, мА";
            // 
            // TextBox_TimeTx
            // 
            this.TextBox_TimeTx.Location = new System.Drawing.Point(135, 29);
            this.TextBox_TimeTx.Name = "TextBox_TimeTx";
            this.TextBox_TimeTx.Size = new System.Drawing.Size(55, 20);
            this.TextBox_TimeTx.TabIndex = 2;
            this.TextBox_TimeTx.Text = "2";
            this.TextBox_TimeTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_TimeTx.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_TimeTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_TimeRx
            // 
            this.TextBox_TimeRx.Location = new System.Drawing.Point(196, 29);
            this.TextBox_TimeRx.Name = "TextBox_TimeRx";
            this.TextBox_TimeRx.Size = new System.Drawing.Size(55, 20);
            this.TextBox_TimeRx.TabIndex = 3;
            this.TextBox_TimeRx.Text = "5";
            this.TextBox_TimeRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_TimeRx.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_TimeRx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_TimeWork
            // 
            this.TextBox_TimeWork.Location = new System.Drawing.Point(74, 29);
            this.TextBox_TimeWork.Name = "TextBox_TimeWork";
            this.TextBox_TimeWork.Size = new System.Drawing.Size(55, 20);
            this.TextBox_TimeWork.TabIndex = 4;
            this.TextBox_TimeWork.Text = "20";
            this.TextBox_TimeWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_TimeWork.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_TimeWork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_CurrentWait
            // 
            this.TextBox_CurrentWait.Location = new System.Drawing.Point(257, 55);
            this.TextBox_CurrentWait.Name = "TextBox_CurrentWait";
            this.TextBox_CurrentWait.Size = new System.Drawing.Size(55, 20);
            this.TextBox_CurrentWait.TabIndex = 5;
            this.TextBox_CurrentWait.Text = "0,5";
            this.TextBox_CurrentWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CurrentWait.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_CurrentWait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_CurrentTx
            // 
            this.TextBox_CurrentTx.Location = new System.Drawing.Point(135, 55);
            this.TextBox_CurrentTx.Name = "TextBox_CurrentTx";
            this.TextBox_CurrentTx.Size = new System.Drawing.Size(55, 20);
            this.TextBox_CurrentTx.TabIndex = 6;
            this.TextBox_CurrentTx.Text = "27";
            this.TextBox_CurrentTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CurrentTx.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_CurrentTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_CurrentRx
            // 
            this.TextBox_CurrentRx.Location = new System.Drawing.Point(196, 55);
            this.TextBox_CurrentRx.Name = "TextBox_CurrentRx";
            this.TextBox_CurrentRx.Size = new System.Drawing.Size(55, 20);
            this.TextBox_CurrentRx.TabIndex = 7;
            this.TextBox_CurrentRx.Text = "15";
            this.TextBox_CurrentRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CurrentRx.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_CurrentRx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_CurrentWork
            // 
            this.TextBox_CurrentWork.Location = new System.Drawing.Point(74, 55);
            this.TextBox_CurrentWork.Name = "TextBox_CurrentWork";
            this.TextBox_CurrentWork.Size = new System.Drawing.Size(55, 20);
            this.TextBox_CurrentWork.TabIndex = 8;
            this.TextBox_CurrentWork.Text = "2";
            this.TextBox_CurrentWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CurrentWork.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_CurrentWork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Передача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Прием";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пробуж.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ожидание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Сон";
            // 
            // TextBox_TimeWait
            // 
            this.TextBox_TimeWait.Location = new System.Drawing.Point(257, 29);
            this.TextBox_TimeWait.Name = "TextBox_TimeWait";
            this.TextBox_TimeWait.Size = new System.Drawing.Size(55, 20);
            this.TextBox_TimeWait.TabIndex = 14;
            this.TextBox_TimeWait.Text = "200";
            this.TextBox_TimeWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_TimeWait.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_TimeWait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_CurrentSleep
            // 
            this.TextBox_CurrentSleep.Location = new System.Drawing.Point(318, 55);
            this.TextBox_CurrentSleep.Name = "TextBox_CurrentSleep";
            this.TextBox_CurrentSleep.Size = new System.Drawing.Size(55, 20);
            this.TextBox_CurrentSleep.TabIndex = 15;
            this.TextBox_CurrentSleep.Text = "0,002";
            this.TextBox_CurrentSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CurrentSleep.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_CurrentSleep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Передач в час, с ожиданием ответа";
            // 
            // TextBox_TxWithACK
            // 
            this.TextBox_TxWithACK.Location = new System.Drawing.Point(205, 93);
            this.TextBox_TxWithACK.Name = "TextBox_TxWithACK";
            this.TextBox_TxWithACK.Size = new System.Drawing.Size(55, 20);
            this.TextBox_TxWithACK.TabIndex = 17;
            this.TextBox_TxWithACK.Text = "1";
            this.TextBox_TxWithACK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_TxWithACK.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_TxWithACK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // TextBox_BatteryCapacity
            // 
            this.TextBox_BatteryCapacity.Location = new System.Drawing.Point(149, 155);
            this.TextBox_BatteryCapacity.Name = "TextBox_BatteryCapacity";
            this.TextBox_BatteryCapacity.Size = new System.Drawing.Size(55, 20);
            this.TextBox_BatteryCapacity.TabIndex = 19;
            this.TextBox_BatteryCapacity.Text = "100";
            this.TextBox_BatteryCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_BatteryCapacity.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_BatteryCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Емкость батарейки, мАч";
            // 
            // TextBox_TimeDays
            // 
            this.TextBox_TimeDays.Location = new System.Drawing.Point(184, 237);
            this.TextBox_TimeDays.Name = "TextBox_TimeDays";
            this.TextBox_TimeDays.ReadOnly = true;
            this.TextBox_TimeDays.Size = new System.Drawing.Size(77, 20);
            this.TextBox_TimeDays.TabIndex = 21;
            this.TextBox_TimeDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Время работы:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Дней";
            // 
            // TextBox_TimeMonth
            // 
            this.TextBox_TimeMonth.Location = new System.Drawing.Point(267, 237);
            this.TextBox_TimeMonth.Name = "TextBox_TimeMonth";
            this.TextBox_TimeMonth.ReadOnly = true;
            this.TextBox_TimeMonth.Size = new System.Drawing.Size(77, 20);
            this.TextBox_TimeMonth.TabIndex = 23;
            this.TextBox_TimeMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_TimeYears
            // 
            this.TextBox_TimeYears.Location = new System.Drawing.Point(350, 237);
            this.TextBox_TimeYears.Name = "TextBox_TimeYears";
            this.TextBox_TimeYears.ReadOnly = true;
            this.TextBox_TimeYears.Size = new System.Drawing.Size(51, 20);
            this.TextBox_TimeYears.TabIndex = 24;
            this.TextBox_TimeYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Месяцев";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(362, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Лет";
            // 
            // TextBox_TxWithoutACK
            // 
            this.TextBox_TxWithoutACK.Location = new System.Drawing.Point(205, 119);
            this.TextBox_TxWithoutACK.Name = "TextBox_TxWithoutACK";
            this.TextBox_TxWithoutACK.Size = new System.Drawing.Size(55, 20);
            this.TextBox_TxWithoutACK.TabIndex = 28;
            this.TextBox_TxWithoutACK.Text = "0";
            this.TextBox_TxWithoutACK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_TxWithoutACK.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_TxWithoutACK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Передач в час, без ответа";
            // 
            // TextBox_Current
            // 
            this.TextBox_Current.Location = new System.Drawing.Point(149, 181);
            this.TextBox_Current.Name = "TextBox_Current";
            this.TextBox_Current.ReadOnly = true;
            this.TextBox_Current.Size = new System.Drawing.Size(55, 20);
            this.TextBox_Current.TabIndex = 30;
            this.TextBox_Current.Text = "100";
            this.TextBox_Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Средний ток, мкА";
            // 
            // TextBox_ErrorPercent
            // 
            this.TextBox_ErrorPercent.Location = new System.Drawing.Point(340, 93);
            this.TextBox_ErrorPercent.Name = "TextBox_ErrorPercent";
            this.TextBox_ErrorPercent.Size = new System.Drawing.Size(48, 20);
            this.TextBox_ErrorPercent.TabIndex = 31;
            this.TextBox_ErrorPercent.Text = "1";
            this.TextBox_ErrorPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_ErrorPercent.TextChanged += new System.EventHandler(this.TextBox_TimeTx_TextChanged);
            this.TextBox_ErrorPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_TimeTx_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(266, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Ошибки, %";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(122, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Часов";
            // 
            // TextBox_TimeHours
            // 
            this.TextBox_TimeHours.Location = new System.Drawing.Point(101, 237);
            this.TextBox_TimeHours.Name = "TextBox_TimeHours";
            this.TextBox_TimeHours.ReadOnly = true;
            this.TextBox_TimeHours.Size = new System.Drawing.Size(77, 20);
            this.TextBox_TimeHours.TabIndex = 33;
            this.TextBox_TimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_RxTimeout
            // 
            this.TextBox_RxTimeout.Location = new System.Drawing.Point(340, 119);
            this.TextBox_RxTimeout.Name = "TextBox_RxTimeout";
            this.TextBox_RxTimeout.Size = new System.Drawing.Size(48, 20);
            this.TextBox_RxTimeout.TabIndex = 35;
            this.TextBox_RxTimeout.Text = "5";
            this.TextBox_RxTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(264, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Таймаут, мс";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 272);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TextBox_RxTimeout);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TextBox_TimeHours);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TextBox_ErrorPercent);
            this.Controls.Add(this.TextBox_Current);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TextBox_TxWithoutACK);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TextBox_TimeYears);
            this.Controls.Add(this.TextBox_TimeMonth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextBox_TimeDays);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBox_BatteryCapacity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBox_CurrentSleep);
            this.Controls.Add(this.TextBox_TxWithACK);
            this.Controls.Add(this.TextBox_TimeWait);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBox_TimeTx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_TimeRx);
            this.Controls.Add(this.TextBox_CurrentWork);
            this.Controls.Add(this.TextBox_TimeWork);
            this.Controls.Add(this.TextBox_CurrentRx);
            this.Controls.Add(this.TextBox_CurrentWait);
            this.Controls.Add(this.TextBox_CurrentTx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " zCalcWorkTime";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_TimeTx;
        private System.Windows.Forms.TextBox TextBox_TimeRx;
        private System.Windows.Forms.TextBox TextBox_TimeWork;
        private System.Windows.Forms.TextBox TextBox_CurrentWait;
        private System.Windows.Forms.TextBox TextBox_CurrentTx;
        private System.Windows.Forms.TextBox TextBox_CurrentRx;
        private System.Windows.Forms.TextBox TextBox_CurrentWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_TimeWait;
        private System.Windows.Forms.TextBox TextBox_CurrentSleep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox_TxWithACK;
        private System.Windows.Forms.TextBox TextBox_BatteryCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox_TimeDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBox_TimeMonth;
        private System.Windows.Forms.TextBox TextBox_TimeYears;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBox_TxWithoutACK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBox_Current;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBox_ErrorPercent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBox_TimeHours;
        private System.Windows.Forms.TextBox TextBox_RxTimeout;
        private System.Windows.Forms.Label label18;
    }
}
