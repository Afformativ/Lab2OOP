namespace EventsDota
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxValue = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxStartDate = new System.Windows.Forms.CheckBox();
            this.checkBoxEndDate = new System.Windows.Forms.CheckBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.checkBoxPrizePool = new System.Windows.Forms.CheckBox();
            this.checkBoxDPCPoints = new System.Windows.Forms.CheckBox();
            this.checkBoxWinner = new System.Windows.Forms.CheckBox();
            this.checkBoxRunnerUp = new System.Windows.Forms.CheckBox();
            this.checkBoxNumberOfTeams = new System.Windows.Forms.CheckBox();
            this.radioLINQ = new System.Windows.Forms.RadioButton();
            this.radioDOM = new System.Windows.Forms.RadioButton();
            this.radioSAX = new System.Windows.Forms.RadioButton();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxStartDate = new System.Windows.Forms.ComboBox();
            this.comboBoxEndDate = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxPrizePool = new System.Windows.Forms.ComboBox();
            this.comboBoxDPCPoints = new System.Windows.Forms.ComboBox();
            this.comboBoxWinner = new System.Windows.Forms.ComboBox();
            this.comboBoxRunnerUp = new System.Windows.Forms.ComboBox();
            this.comboBoxNumberOfTeams = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTransToHTML = new System.Windows.Forms.Button();
            this.btnOpenHTML = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(381, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(407, 330);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // checkBoxValue
            // 
            this.checkBoxValue.AutoSize = true;
            this.checkBoxValue.Location = new System.Drawing.Point(12, 37);
            this.checkBoxValue.Name = "checkBoxValue";
            this.checkBoxValue.Size = new System.Drawing.Size(66, 21);
            this.checkBoxValue.TabIndex = 1;
            this.checkBoxValue.Text = "Value";
            this.checkBoxValue.UseVisualStyleBackColor = true;
            this.checkBoxValue.CheckedChanged += new System.EventHandler(this.checkBoxValue_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(12, 64);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(67, 21);
            this.checkBoxName.TabIndex = 2;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxStartDate
            // 
            this.checkBoxStartDate.AutoSize = true;
            this.checkBoxStartDate.Location = new System.Drawing.Point(12, 91);
            this.checkBoxStartDate.Name = "checkBoxStartDate";
            this.checkBoxStartDate.Size = new System.Drawing.Size(94, 21);
            this.checkBoxStartDate.TabIndex = 3;
            this.checkBoxStartDate.Text = "Start Date";
            this.checkBoxStartDate.UseVisualStyleBackColor = true;
            this.checkBoxStartDate.CheckedChanged += new System.EventHandler(this.checkBoxStartDate_CheckedChanged);
            // 
            // checkBoxEndDate
            // 
            this.checkBoxEndDate.AutoSize = true;
            this.checkBoxEndDate.Location = new System.Drawing.Point(12, 118);
            this.checkBoxEndDate.Name = "checkBoxEndDate";
            this.checkBoxEndDate.Size = new System.Drawing.Size(89, 21);
            this.checkBoxEndDate.TabIndex = 4;
            this.checkBoxEndDate.Text = "End Date";
            this.checkBoxEndDate.UseVisualStyleBackColor = true;
            this.checkBoxEndDate.CheckedChanged += new System.EventHandler(this.checkBoxEndDate_CheckedChanged);
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Location = new System.Drawing.Point(12, 145);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.Size = new System.Drawing.Size(79, 21);
            this.checkBoxCountry.TabIndex = 5;
            this.checkBoxCountry.Text = "Country";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            this.checkBoxCountry.CheckedChanged += new System.EventHandler(this.checkBoxCountry_CheckedChanged);
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Location = new System.Drawing.Point(12, 172);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(53, 21);
            this.checkBoxCity.TabIndex = 6;
            this.checkBoxCity.Text = "City";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            this.checkBoxCity.CheckedChanged += new System.EventHandler(this.checkBoxCity_CheckedChanged);
            // 
            // checkBoxPrizePool
            // 
            this.checkBoxPrizePool.AutoSize = true;
            this.checkBoxPrizePool.Location = new System.Drawing.Point(12, 199);
            this.checkBoxPrizePool.Name = "checkBoxPrizePool";
            this.checkBoxPrizePool.Size = new System.Drawing.Size(90, 21);
            this.checkBoxPrizePool.TabIndex = 7;
            this.checkBoxPrizePool.Text = "PrizePool";
            this.checkBoxPrizePool.UseVisualStyleBackColor = true;
            this.checkBoxPrizePool.CheckedChanged += new System.EventHandler(this.checkBoxPrizePool_CheckedChanged);
            // 
            // checkBoxDPCPoints
            // 
            this.checkBoxDPCPoints.AutoSize = true;
            this.checkBoxDPCPoints.Location = new System.Drawing.Point(12, 226);
            this.checkBoxDPCPoints.Name = "checkBoxDPCPoints";
            this.checkBoxDPCPoints.Size = new System.Drawing.Size(101, 21);
            this.checkBoxDPCPoints.TabIndex = 8;
            this.checkBoxDPCPoints.Text = "DPC Points";
            this.checkBoxDPCPoints.UseVisualStyleBackColor = true;
            this.checkBoxDPCPoints.CheckedChanged += new System.EventHandler(this.checkBoxDPCPoints_CheckedChanged);
            // 
            // checkBoxWinner
            // 
            this.checkBoxWinner.AutoSize = true;
            this.checkBoxWinner.Location = new System.Drawing.Point(12, 253);
            this.checkBoxWinner.Name = "checkBoxWinner";
            this.checkBoxWinner.Size = new System.Drawing.Size(75, 21);
            this.checkBoxWinner.TabIndex = 9;
            this.checkBoxWinner.Text = "Winner";
            this.checkBoxWinner.UseVisualStyleBackColor = true;
            this.checkBoxWinner.CheckedChanged += new System.EventHandler(this.checkBoxWinner_CheckedChanged);
            // 
            // checkBoxRunnerUp
            // 
            this.checkBoxRunnerUp.AutoSize = true;
            this.checkBoxRunnerUp.Location = new System.Drawing.Point(12, 280);
            this.checkBoxRunnerUp.Name = "checkBoxRunnerUp";
            this.checkBoxRunnerUp.Size = new System.Drawing.Size(100, 21);
            this.checkBoxRunnerUp.TabIndex = 10;
            this.checkBoxRunnerUp.Text = "Runner-Up";
            this.checkBoxRunnerUp.UseVisualStyleBackColor = true;
            this.checkBoxRunnerUp.CheckedChanged += new System.EventHandler(this.checkBoxRunnerUp_CheckedChanged);
            // 
            // checkBoxNumberOfTeams
            // 
            this.checkBoxNumberOfTeams.AutoSize = true;
            this.checkBoxNumberOfTeams.Location = new System.Drawing.Point(12, 307);
            this.checkBoxNumberOfTeams.Name = "checkBoxNumberOfTeams";
            this.checkBoxNumberOfTeams.Size = new System.Drawing.Size(138, 21);
            this.checkBoxNumberOfTeams.TabIndex = 11;
            this.checkBoxNumberOfTeams.Text = "Number of teams";
            this.checkBoxNumberOfTeams.UseVisualStyleBackColor = true;
            this.checkBoxNumberOfTeams.CheckedChanged += new System.EventHandler(this.checkBoxNumberOfTeams_CheckedChanged);
            // 
            // radioLINQ
            // 
            this.radioLINQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioLINQ.AutoSize = true;
            this.radioLINQ.Location = new System.Drawing.Point(13, 364);
            this.radioLINQ.Name = "radioLINQ";
            this.radioLINQ.Size = new System.Drawing.Size(61, 21);
            this.radioLINQ.TabIndex = 12;
            this.radioLINQ.TabStop = true;
            this.radioLINQ.Text = "LINQ";
            this.radioLINQ.UseVisualStyleBackColor = true;
            // 
            // radioDOM
            // 
            this.radioDOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioDOM.AutoSize = true;
            this.radioDOM.Location = new System.Drawing.Point(89, 364);
            this.radioDOM.Name = "radioDOM";
            this.radioDOM.Size = new System.Drawing.Size(61, 21);
            this.radioDOM.TabIndex = 13;
            this.radioDOM.TabStop = true;
            this.radioDOM.Text = "DOM";
            this.radioDOM.UseVisualStyleBackColor = true;
            // 
            // radioSAX
            // 
            this.radioSAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioSAX.AutoSize = true;
            this.radioSAX.Location = new System.Drawing.Point(156, 364);
            this.radioSAX.Name = "radioSAX";
            this.radioSAX.Size = new System.Drawing.Size(56, 21);
            this.radioSAX.TabIndex = 14;
            this.radioSAX.TabStop = true;
            this.radioSAX.Text = "SAX";
            this.radioSAX.UseVisualStyleBackColor = true;
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(156, 37);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(223, 24);
            this.comboBoxValue.TabIndex = 15;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(156, 64);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(223, 24);
            this.comboBoxName.TabIndex = 16;
            // 
            // comboBoxStartDate
            // 
            this.comboBoxStartDate.FormattingEnabled = true;
            this.comboBoxStartDate.Location = new System.Drawing.Point(156, 91);
            this.comboBoxStartDate.Name = "comboBoxStartDate";
            this.comboBoxStartDate.Size = new System.Drawing.Size(223, 24);
            this.comboBoxStartDate.TabIndex = 17;
            // 
            // comboBoxEndDate
            // 
            this.comboBoxEndDate.FormattingEnabled = true;
            this.comboBoxEndDate.Location = new System.Drawing.Point(156, 118);
            this.comboBoxEndDate.Name = "comboBoxEndDate";
            this.comboBoxEndDate.Size = new System.Drawing.Size(223, 24);
            this.comboBoxEndDate.TabIndex = 18;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(156, 145);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(223, 24);
            this.comboBoxCountry.TabIndex = 19;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(156, 172);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(223, 24);
            this.comboBoxCity.TabIndex = 20;
            // 
            // comboBoxPrizePool
            // 
            this.comboBoxPrizePool.FormattingEnabled = true;
            this.comboBoxPrizePool.Location = new System.Drawing.Point(156, 199);
            this.comboBoxPrizePool.Name = "comboBoxPrizePool";
            this.comboBoxPrizePool.Size = new System.Drawing.Size(223, 24);
            this.comboBoxPrizePool.TabIndex = 21;
            // 
            // comboBoxDPCPoints
            // 
            this.comboBoxDPCPoints.FormattingEnabled = true;
            this.comboBoxDPCPoints.Location = new System.Drawing.Point(156, 226);
            this.comboBoxDPCPoints.Name = "comboBoxDPCPoints";
            this.comboBoxDPCPoints.Size = new System.Drawing.Size(223, 24);
            this.comboBoxDPCPoints.TabIndex = 22;
            // 
            // comboBoxWinner
            // 
            this.comboBoxWinner.FormattingEnabled = true;
            this.comboBoxWinner.Location = new System.Drawing.Point(156, 253);
            this.comboBoxWinner.Name = "comboBoxWinner";
            this.comboBoxWinner.Size = new System.Drawing.Size(223, 24);
            this.comboBoxWinner.TabIndex = 23;
            // 
            // comboBoxRunnerUp
            // 
            this.comboBoxRunnerUp.FormattingEnabled = true;
            this.comboBoxRunnerUp.Location = new System.Drawing.Point(156, 280);
            this.comboBoxRunnerUp.Name = "comboBoxRunnerUp";
            this.comboBoxRunnerUp.Size = new System.Drawing.Size(223, 24);
            this.comboBoxRunnerUp.TabIndex = 24;
            // 
            // comboBoxNumberOfTeams
            // 
            this.comboBoxNumberOfTeams.FormattingEnabled = true;
            this.comboBoxNumberOfTeams.Location = new System.Drawing.Point(156, 307);
            this.comboBoxNumberOfTeams.Name = "comboBoxNumberOfTeams";
            this.comboBoxNumberOfTeams.Size = new System.Drawing.Size(223, 24);
            this.comboBoxNumberOfTeams.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(260, 364);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTransToHTML
            // 
            this.btnTransToHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTransToHTML.Location = new System.Drawing.Point(13, 404);
            this.btnTransToHTML.Name = "btnTransToHTML";
            this.btnTransToHTML.Size = new System.Drawing.Size(164, 34);
            this.btnTransToHTML.TabIndex = 27;
            this.btnTransToHTML.Text = "Transform to HTML";
            this.btnTransToHTML.UseVisualStyleBackColor = true;
            this.btnTransToHTML.Click += new System.EventHandler(this.btnTransToHTML_Click);
            // 
            // btnOpenHTML
            // 
            this.btnOpenHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenHTML.Location = new System.Drawing.Point(215, 404);
            this.btnOpenHTML.Name = "btnOpenHTML";
            this.btnOpenHTML.Size = new System.Drawing.Size(164, 34);
            this.btnOpenHTML.TabIndex = 28;
            this.btnOpenHTML.Text = "Open HTML";
            this.btnOpenHTML.UseVisualStyleBackColor = true;
            this.btnOpenHTML.Click += new System.EventHandler(this.btnOpenHTML_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(615, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 34);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(414, 404);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(164, 34);
            this.btnHelp.TabIndex = 30;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpenHTML);
            this.Controls.Add(this.btnTransToHTML);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxNumberOfTeams);
            this.Controls.Add(this.comboBoxRunnerUp);
            this.Controls.Add(this.comboBoxWinner);
            this.Controls.Add(this.comboBoxDPCPoints);
            this.Controls.Add(this.comboBoxPrizePool);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxEndDate);
            this.Controls.Add(this.comboBoxStartDate);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.radioSAX);
            this.Controls.Add(this.radioDOM);
            this.Controls.Add(this.radioLINQ);
            this.Controls.Add(this.checkBoxNumberOfTeams);
            this.Controls.Add(this.checkBoxRunnerUp);
            this.Controls.Add(this.checkBoxWinner);
            this.Controls.Add(this.checkBoxDPCPoints);
            this.Controls.Add(this.checkBoxPrizePool);
            this.Controls.Add(this.checkBoxCity);
            this.Controls.Add(this.checkBoxCountry);
            this.Controls.Add(this.checkBoxEndDate);
            this.Controls.Add(this.checkBoxStartDate);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxValue);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Dota 2 Events by Hrabar Oleksandr K-25";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxValue;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxStartDate;
        private System.Windows.Forms.CheckBox checkBoxEndDate;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.CheckBox checkBoxPrizePool;
        private System.Windows.Forms.CheckBox checkBoxDPCPoints;
        private System.Windows.Forms.CheckBox checkBoxWinner;
        private System.Windows.Forms.CheckBox checkBoxRunnerUp;
        private System.Windows.Forms.CheckBox checkBoxNumberOfTeams;
        private System.Windows.Forms.RadioButton radioLINQ;
        private System.Windows.Forms.RadioButton radioDOM;
        private System.Windows.Forms.RadioButton radioSAX;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxStartDate;
        private System.Windows.Forms.ComboBox comboBoxEndDate;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxPrizePool;
        private System.Windows.Forms.ComboBox comboBoxDPCPoints;
        private System.Windows.Forms.ComboBox comboBoxWinner;
        private System.Windows.Forms.ComboBox comboBoxRunnerUp;
        private System.Windows.Forms.ComboBox comboBoxNumberOfTeams;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTransToHTML;
        private System.Windows.Forms.Button btnOpenHTML;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
    }
}

