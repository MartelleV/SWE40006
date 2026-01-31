namespace HelloWorldApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for initializing the components.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ---------------------------------------------------------------
            // Form — DPI-aware scaling so everything sizes correctly inside
            // the ARM64 VM regardless of the display scale factor.
            // AutoScaleDimensions / AutoScaleMode.Font scales every control
            // proportionally when the runtime font metrics differ from the
            // design-time values below.
            // ---------------------------------------------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(760, 720);
            this.MinimumSize = new System.Drawing.Size(760, 720);
            this.Text = "HelloWorldApp \u2014 WiX Deployment Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // ---------------------------------------------------------------
            // Title label — spans the full client width at the top.
            // ---------------------------------------------------------------
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Size = new System.Drawing.Size(728, 32);
            this.lblTitle.Text = "HelloWorldApp \u2014 Multi-DLL WiX Deployment Demo";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ---------------------------------------------------------------
            // MathLib group box — left half.
            // Button widths are 158 px each; "Calculate" and "Factorial of A"
            // both fit comfortably at Segoe UI 9 pt inside that width.
            // ---------------------------------------------------------------
            this.grpMath = new System.Windows.Forms.GroupBox();
            this.grpMath.Location = new System.Drawing.Point(12, 48);
            this.grpMath.Size = new System.Drawing.Size(358, 155);
            this.grpMath.Text = "MathLib.dll \u2014 Math Operations";
            this.grpMath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblA = new System.Windows.Forms.Label();
            this.lblA.Location = new System.Drawing.Point(15, 35);
            this.lblA.Size = new System.Drawing.Size(90, 22);
            this.lblA.Text = "Number A:";
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpMath.Controls.Add(this.lblA);

            this.txtInputA = new System.Windows.Forms.TextBox();
            this.txtInputA.Location = new System.Drawing.Point(110, 35);
            this.txtInputA.Size = new System.Drawing.Size(90, 22);
            this.txtInputA.Text = "7";
            this.txtInputA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpMath.Controls.Add(this.txtInputA);

            this.lblB = new System.Windows.Forms.Label();
            this.lblB.Location = new System.Drawing.Point(15, 62);
            this.lblB.Size = new System.Drawing.Size(90, 22);
            this.lblB.Text = "Number B:";
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpMath.Controls.Add(this.lblB);

            this.txtInputB = new System.Windows.Forms.TextBox();
            this.txtInputB.Location = new System.Drawing.Point(110, 62);
            this.txtInputB.Size = new System.Drawing.Size(90, 22);
            this.txtInputB.Text = "5";
            this.txtInputB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpMath.Controls.Add(this.txtInputB);

            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculate.Location = new System.Drawing.Point(15, 98);
            this.btnCalculate.Size = new System.Drawing.Size(158, 36);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            this.grpMath.Controls.Add(this.btnCalculate);

            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnFactorial.Location = new System.Drawing.Point(183, 98);
            this.btnFactorial.Size = new System.Drawing.Size(158, 36);
            this.btnFactorial.Text = "Factorial of A";
            this.btnFactorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFactorial.Click += new System.EventHandler(this.BtnFactorial_Click);
            this.grpMath.Controls.Add(this.btnFactorial);

            // ---------------------------------------------------------------
            // StringLib group box — right half.
            // ---------------------------------------------------------------
            this.grpString = new System.Windows.Forms.GroupBox();
            this.grpString.Location = new System.Drawing.Point(378, 48);
            this.grpString.Size = new System.Drawing.Size(362, 155);
            this.grpString.Text = "StringLib.dll \u2014 String Operations";
            this.grpString.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblStringInput = new System.Windows.Forms.Label();
            this.lblStringInput.Location = new System.Drawing.Point(15, 30);
            this.lblStringInput.Size = new System.Drawing.Size(332, 22);
            this.lblStringInput.Text = "Input String:";
            this.lblStringInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpString.Controls.Add(this.lblStringInput);

            this.txtInputString = new System.Windows.Forms.TextBox();
            this.txtInputString.Location = new System.Drawing.Point(15, 52);
            this.txtInputString.Size = new System.Drawing.Size(332, 22);
            this.txtInputString.Text = "hello world deployment";
            this.txtInputString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpString.Controls.Add(this.txtInputString);

            this.btnTransform = new System.Windows.Forms.Button();
            this.btnTransform.Location = new System.Drawing.Point(15, 90);
            this.btnTransform.Size = new System.Drawing.Size(158, 36);
            this.btnTransform.Text = "Transform";
            this.btnTransform.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
            this.grpString.Controls.Add(this.btnTransform);

            this.btnPalindrome = new System.Windows.Forms.Button();
            this.btnPalindrome.Location = new System.Drawing.Point(183, 90);
            this.btnPalindrome.Size = new System.Drawing.Size(158, 36);
            this.btnPalindrome.Text = "Palindrome";
            this.btnPalindrome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPalindrome.Click += new System.EventHandler(this.BtnPalindrome_Click);
            this.grpString.Controls.Add(this.btnPalindrome);

            // ---------------------------------------------------------------
            // Output group box — anchored on all four sides so it stretches
            // cleanly if the user resizes the form.  The inner TextBox is
            // also anchored so it fills the group box.
            // ---------------------------------------------------------------
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpOutput.Location = new System.Drawing.Point(12, 215);
            this.grpOutput.Size = new System.Drawing.Size(728, 410);
            this.grpOutput.Text = "Output";
            this.grpOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpOutput.Anchor = System.Windows.Forms.AnchorStyles.Top
                                  | System.Windows.Forms.AnchorStyles.Bottom
                                  | System.Windows.Forms.AnchorStyles.Left
                                  | System.Windows.Forms.AnchorStyles.Right;

            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtOutput.Location = new System.Drawing.Point(12, 22);
            this.txtOutput.Size = new System.Drawing.Size(704, 378);
            this.txtOutput.Multiline = true;
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtOutput.Text = "Click any button above to see output from the loaded DLLs.";
            this.txtOutput.Anchor = System.Windows.Forms.AnchorStyles.Top
                                  | System.Windows.Forms.AnchorStyles.Bottom
                                  | System.Windows.Forms.AnchorStyles.Left
                                  | System.Windows.Forms.AnchorStyles.Right;
            this.grpOutput.Controls.Add(this.txtOutput);

            // ---------------------------------------------------------------
            // About button — anchored to the bottom-left so it stays visible
            // regardless of form height.
            // ---------------------------------------------------------------
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnAbout.Location = new System.Drawing.Point(12, 638);
            this.btnAbout.Size = new System.Drawing.Size(230, 38);
            this.btnAbout.Text = "About / DLL Info";
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                                 | System.Windows.Forms.AnchorStyles.Left;

            // ---------------------------------------------------------------
            // Wire everything into the form.
            // ---------------------------------------------------------------
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMath);
            this.Controls.Add(this.grpString);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.btnAbout);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpMath;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.GroupBox grpString;
        private System.Windows.Forms.Label lblStringInput;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnAbout;
    }
}