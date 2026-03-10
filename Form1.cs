using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cockfight_Betting_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Cockfight Betting System";
            this.Size = new System.Drawing.Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Header Panel
            Panel headerPanel = new Panel();
            headerPanel.BackColor = Color.FromArgb(50, 50, 50);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            headerPanel.Padding = new Padding(15);

            Label titleLabel = new Label();
            titleLabel.Text = "🔴 LIVE - COCKFIGHT BETTING";
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(15, 15);
            headerPanel.Controls.Add(titleLabel);
            this.Controls.Add(headerPanel);

            // Main content panel
            Panel contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.FromArgb(30, 30, 30);
            contentPanel.Padding = new Padding(20);

            // Fight title
            Label fightTitleLabel = new Label();
            fightTitleLabel.Text = "FIGHT #1066 - SELECT YOUR ROOSTER";
            fightTitleLabel.ForeColor = Color.Yellow;
            fightTitleLabel.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            fightTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            fightTitleLabel.Dock = DockStyle.Top;
            fightTitleLabel.Height = 50;
            // fight title added before layout so we can bring to front later
            contentPanel.Controls.Add(fightTitleLabel);

            // Table layout for betting panels and draw
            TableLayoutPanel layoutPanel = new TableLayoutPanel();
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.ColumnCount = 3;
            layoutPanel.RowCount = 2;
            layoutPanel.Padding = new Padding(10);
            layoutPanel.BackColor = Color.FromArgb(30, 30, 30);

            // Set column styles - 3 equal columns
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34f));

            // Set row styles
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));

            // MERON Panel (Left, Red)
            Panel meronPanel = new Panel();
            meronPanel.BackColor = Color.FromArgb(80, 40, 40);
            meronPanel.BorderStyle = BorderStyle.FixedSingle;
            meronPanel.Padding = new Padding(20);
            meronPanel.Dock = DockStyle.Fill;
            meronPanel.Margin = new Padding(5);

            Label meronTitleLabel = new Label();
            meronTitleLabel.Text = "MERON";
            meronTitleLabel.ForeColor = Color.FromArgb(255, 100, 100);
            meronTitleLabel.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            meronTitleLabel.TextAlign = ContentAlignment.TopCenter;
            meronTitleLabel.Dock = DockStyle.Top;
            meronTitleLabel.Height = 50;
            meronPanel.Controls.Add(meronTitleLabel);

            Label meronAmountLabel = new Label();
            meronAmountLabel.Text = "0";
            meronAmountLabel.ForeColor = Color.White;
            meronAmountLabel.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            meronAmountLabel.TextAlign = ContentAlignment.TopCenter;
            meronAmountLabel.Dock = DockStyle.Top;
            meronAmountLabel.Height = 80;
            meronPanel.Controls.Add(meronAmountLabel);

            Label payoutMeronLabel = new Label();
            payoutMeronLabel.Text = "PAYOUT: 0.00";
            payoutMeronLabel.ForeColor = Color.Orange;
            payoutMeronLabel.Font = new Font("Segoe UI", 10);
            payoutMeronLabel.TextAlign = ContentAlignment.TopCenter;
            payoutMeronLabel.Dock = DockStyle.Top;
            payoutMeronLabel.Height = 30;
            meronPanel.Controls.Add(payoutMeronLabel);

            Button meronBetButton = new Button();
            meronBetButton.Text = "BET";
            meronBetButton.BackColor = Color.FromArgb(255, 100, 100);
            meronBetButton.ForeColor = Color.White;
            meronBetButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            meronBetButton.Dock = DockStyle.Bottom;
            meronBetButton.Height = 60;
            meronBetButton.FlatStyle = FlatStyle.Flat;
            meronBetButton.FlatAppearance.BorderSize = 0;
            meronBetButton.Click += MeronBetButton_Click;
            meronPanel.Controls.Add(meronBetButton);

            layoutPanel.Controls.Add(meronPanel, 0, 0);

            // WALA Panel (Middle, Blue)
            Panel walaPanel = new Panel();
            walaPanel.BackColor = Color.FromArgb(40, 80, 120);
            walaPanel.BorderStyle = BorderStyle.FixedSingle;
            walaPanel.Padding = new Padding(20);
            walaPanel.Dock = DockStyle.Fill;
            walaPanel.Margin = new Padding(5);

            Label walaTitleLabel = new Label();
            walaTitleLabel.Text = "WALA";
            walaTitleLabel.ForeColor = Color.FromArgb(100, 150, 255);
            walaTitleLabel.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            walaTitleLabel.TextAlign = ContentAlignment.TopCenter;
            walaTitleLabel.Dock = DockStyle.Top;
            walaTitleLabel.Height = 50;
            walaPanel.Controls.Add(walaTitleLabel);

            Label walaAmountLabel = new Label();
            walaAmountLabel.Text = "1000.00";
            walaAmountLabel.ForeColor = Color.White;
            walaAmountLabel.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            walaAmountLabel.TextAlign = ContentAlignment.TopCenter;
            walaAmountLabel.Dock = DockStyle.Top;
            walaAmountLabel.Height = 80;
            walaPanel.Controls.Add(walaAmountLabel);

            Label payoutWalaLabel = new Label();
            payoutWalaLabel.Text = "PAYOUT: 0";
            payoutWalaLabel.ForeColor = Color.Orange;
            payoutWalaLabel.Font = new Font("Segoe UI", 10);
            payoutWalaLabel.TextAlign = ContentAlignment.TopCenter;
            payoutWalaLabel.Dock = DockStyle.Top;
            payoutWalaLabel.Height = 30;
            walaPanel.Controls.Add(payoutWalaLabel);

            Button walaBetButton = new Button();
            walaBetButton.Text = "BET";
            walaBetButton.BackColor = Color.FromArgb(100, 150, 255);
            walaBetButton.ForeColor = Color.White;
            walaBetButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            walaBetButton.Dock = DockStyle.Bottom;
            walaBetButton.Height = 60;
            walaBetButton.FlatStyle = FlatStyle.Flat;
            walaBetButton.FlatAppearance.BorderSize = 0;
            walaBetButton.Click += WalaBetButton_Click;
            walaPanel.Controls.Add(walaBetButton);

            layoutPanel.Controls.Add(walaPanel, 1, 0);

            // DRAW Panel (Right, Green)
            Panel drawTopPanel = new Panel();
            drawTopPanel.BackColor = Color.FromArgb(40, 100, 40);
            drawTopPanel.BorderStyle = BorderStyle.FixedSingle;
            drawTopPanel.Padding = new Padding(20);
            drawTopPanel.Dock = DockStyle.Fill;
            drawTopPanel.Margin = new Padding(5);

            Label drawTitleLabel = new Label();
            drawTitleLabel.Text = "DRAW";
            drawTitleLabel.ForeColor = Color.LimeGreen;
            drawTitleLabel.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            drawTitleLabel.TextAlign = ContentAlignment.TopCenter;
            drawTitleLabel.Dock = DockStyle.Top;
            drawTitleLabel.Height = 50;
            drawTopPanel.Controls.Add(drawTitleLabel);

            Label drawAmountLabel = new Label();
            drawAmountLabel.Text = "0";
            drawAmountLabel.ForeColor = Color.White;
            drawAmountLabel.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            drawAmountLabel.TextAlign = ContentAlignment.TopCenter;
            drawAmountLabel.Dock = DockStyle.Top;
            drawAmountLabel.Height = 80;
            drawTopPanel.Controls.Add(drawAmountLabel);

            Button drawBetButton = new Button();
            drawBetButton.Text = "BET";
            drawBetButton.BackColor = Color.LimeGreen;
            drawBetButton.ForeColor = Color.Black;
            drawBetButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            drawBetButton.Dock = DockStyle.Bottom;
            drawBetButton.Height = 60;
            drawBetButton.FlatStyle = FlatStyle.Flat;
            drawBetButton.FlatAppearance.BorderSize = 0;
            drawBetButton.Click += DrawBetButton_Click;
            drawTopPanel.Controls.Add(drawBetButton);

            layoutPanel.Controls.Add(drawTopPanel, 2, 0);

            // Bottom section spanning all columns
            Panel bottomSectionPanel = new Panel();
            bottomSectionPanel.BackColor = Color.FromArgb(30, 30, 30);
            bottomSectionPanel.Dock = DockStyle.Fill;
            bottomSectionPanel.Margin = new Padding(5);
            bottomSectionPanel.Padding = new Padding(10);

            Label bottomLabel = new Label();
            bottomLabel.Text = "Recent Stats:";
            bottomLabel.ForeColor = Color.White;
            bottomLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            bottomLabel.AutoSize = true;
            bottomLabel.Location = new Point(10, 5);
            bottomSectionPanel.Controls.Add(bottomLabel);

            layoutPanel.Controls.Add(bottomSectionPanel, 0, 1);
            layoutPanel.SetColumnSpan(bottomSectionPanel, 3);

            contentPanel.Controls.Add(layoutPanel);
            // ensure title remains visible above layoutPanel
            fightTitleLabel.BringToFront();
            this.Controls.Add(contentPanel);

            // Bottom control panel
            Panel controlPanel = new Panel();
            controlPanel.BackColor = Color.FromArgb(50, 50, 50);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Height = 80;
            controlPanel.Padding = new Padding(15);

            Label controlLabel = new Label();
            controlLabel.Text = "Quick Actions:";
            controlLabel.ForeColor = Color.White;
            controlLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            controlLabel.AutoSize = true;
            controlLabel.Location = new Point(15, 10);
            controlPanel.Controls.Add(controlLabel);

            Button loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.BackColor = Color.FromArgb(70, 120, 180);
            loginButton.ForeColor = Color.White;
            loginButton.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            loginButton.Size = new Size(110, 45);
            loginButton.Location = new Point(15, 35);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Click += LoginButton_Click;
            controlPanel.Controls.Add(loginButton);

            Button registerButton = new Button();
            registerButton.Text = "Register";
            registerButton.BackColor = Color.FromArgb(70, 120, 180);
            registerButton.ForeColor = Color.White;
            registerButton.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            registerButton.Size = new Size(110, 45);
            registerButton.Location = new Point(135, 35);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.Click += RegisterButton_Click;
            controlPanel.Controls.Add(registerButton);

            Button exitButton = new Button();
            exitButton.Text = "Exit";
            exitButton.BackColor = Color.FromArgb(180, 80, 80);
            exitButton.ForeColor = Color.White;
            exitButton.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            exitButton.Size = new Size(110, 45);
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Location = new Point(controlPanel.ClientSize.Width - 125, 35);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Click += ExitButton_Click;
            controlPanel.Controls.Add(exitButton);

            this.Controls.Add(controlPanel);
        }

        private void MeronBetButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Placing bet on MERON...\nFunctionality coming soon!", "Meron Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WalaBetButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Placing bet on WALA...\nFunctionality coming soon!", "Wala Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DrawBetButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Placing bet on DRAW...\nFunctionality coming soon!", "Draw Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Login functionality not implemented yet.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Register functionality not implemented yet.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

//type this shit in the terminal to run: dotnet run --project main.csproj