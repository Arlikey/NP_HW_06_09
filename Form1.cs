using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using Timer = System.Windows.Forms.Timer;

namespace NP_HW_06_09
{
    public partial class Form1 : Form
    {
        private static readonly string apiKey = "your_api_key";
        private static readonly string basicURL = "https://api.random.org/json-rpc/2/invoke";

        private static bool gameModeVsPC = false;
        private bool isPlayerTurn = true;

        private int player1Score = 0;
        private int player2Score = 0;

        private Timer animationTimer;
        private int animationFrame = 0;
        public Form1()
        {
            InitializeComponent();
            dice1Button.Visible = false;
            dice2Button.Visible = false;
            rollButton.Visible = false;
            player1RollsList.Visible = false;
            player2RollsList.Visible = false;
            player1ScoreLabel.Visible = false;
            player2ScoreLabel.Visible = false;
            animationTimer = new Timer { Interval = 100 };
            animationTimer.Tick += AnimationTimer_Tick;
            playerVsComputerButton.Click += gameModeChosen;
            playerVsPlayerButton.Click += gameModeChosen;
        }

        private async void rollButton_Click(object sender, EventArgs e)
        {
            if (gameModeVsPC)
            {
                await RollDiceHumanVsComputer();
            }
            else
            {
                await RollDiceHumanVsHuman();
            }
        }

        private async Task RollDiceHumanVsComputer()
        {
            if (!isPlayerTurn) return;

            StartDiceAnimation();

            int[] diceValues = await RollDice();

            StopDiceAnimation(diceValues);

            player1RollsList.Items.Add($"[{diceValues[0]}] + [{diceValues[1]}]");
            player1Score += diceValues[0] + diceValues[1];
            player1ScoreLabel.Text = $"Игрок: {player1Score}";

            if (player1Score >= 50)
            {
                MessageBox.Show("Вы выиграли!");
                Environment.Exit(0);
            }

            rollButton.Enabled = false;
            await Task.Delay(1000);

            StartDiceAnimation();

            diceValues = await RollDice();

            StopDiceAnimation(diceValues);

            player2RollsList.Items.Add($"[{diceValues[0]}] + [{diceValues[1]}]");
            player2Score += diceValues[0] + diceValues[1];
            player2ScoreLabel.Text = $"Компьютер: {player2Score}";

            if (player2Score >= 50)
            {
                MessageBox.Show("Компьютер выиграл!");
                Environment.Exit(0);
            }
            rollButton.Enabled = true;
        }

        private async Task RollDiceHumanVsHuman()
        {
            StartDiceAnimation();

            int[] diceValues = await RollDice();

            StopDiceAnimation(diceValues);
            if (isPlayerTurn)
            {
                player1RollsList.Items.Add($"[{diceValues[0]}] + [{diceValues[1]}]");
                player1Score += diceValues[0] + diceValues[1];
                player1ScoreLabel.Text = $"Игрок 1: {player1Score}";

                if (player1Score >= 50)
                {
                    MessageBox.Show("Игрок 1 выиграл!");
                    Environment.Exit(0);
                }
            }
            else
            {
                player2RollsList.Items.Add($"[{diceValues[0]}] + [{diceValues[1]}]");
                player2Score += diceValues[0] + diceValues[1];
                player2ScoreLabel.Text = $"Игрок 2: {player2Score}";

                if (player2Score >= 50)
                {
                    MessageBox.Show("Игрок 2 выиграл!");
                    Environment.Exit(0);
                }
            }

            isPlayerTurn = !isPlayerTurn;
        }

        private async Task<int[]> RollDice()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var jsonPayload = new
                {
                    jsonrpc = "2.0",
                    method = "generateIntegers",
                    @params = new
                    {
                        apiKey = apiKey,
                        n = 2,
                        min = 1,
                        max = 6
                    },
                    id = 1
                };
                var response = await httpClient.PostAsJsonAsync(basicURL, jsonPayload);
                var httpResult = await response.Content.ReadFromJsonAsync<RandomResult>();
                dice1Button.Text = httpResult.result.random.data[0].ToString();
                dice2Button.Text = httpResult.result.random.data[1].ToString();
                return httpResult.result.random.data;
            }
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Правила игры в кости:\n\n" +
                "1. Выберите режим игры:\n" +
                "\t- Человек против Человека\n" +
                "\t- Человек против Компьютера\n\n" +
                "2. В режиме Человек против Человека:\n" +
                "\t- Игроки по очереди бросают кости.\n" +
                "\t- Кости бросаются с помощью кнопки 'Бросить'.\n" +
                "\t- Игрок, который первым наберет 50 очков, выигрывает.\n\n" +
                "3. В режиме Человек против Компьютера:\n" +
                "\t- Игрок бросает кости первым.\n" +
                "\t- Компьютер бросает кости автоматически.\n" +
                "\t- Игрок, который первым наберет 50 очков, выигрывает.\n\n" +
                "4. Для броска костей нажмите кнопку 'Roll'.\n" +
                "5. Наслаждайтесь игрой и удачи!",
                "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Question
            );
        }
        private void StartDiceAnimation()
        {
            animationFrame = 1;
            animationTimer.Start();
        }

        private void StopDiceAnimation(int[] finalValues)
        {
            animationTimer.Stop();
            dice1Button.Text = finalValues[0].ToString();
            dice2Button.Text = finalValues[1].ToString();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            dice1Button.Text = (animationFrame % 6 + 1).ToString();
            dice2Button.Text = ((animationFrame + 1) % 6 + 1).ToString();
            animationFrame++;
        }
        private void gameModeChosen(object sender, EventArgs e)
        {
            dice1Button.Visible = true;
            dice2Button.Visible = true;
            rollButton.Visible = true;
            player1RollsList.Visible = true;
            player2RollsList.Visible = true;
            player1ScoreLabel.Visible = true;
            player2ScoreLabel.Visible = true;
            label1.Visible = false;
            playerVsComputerButton.Visible = false;
            playerVsPlayerButton.Visible = false;
        }
        private void playerVsComputerButton_Click(object sender, EventArgs e)
        {
            gameModeVsPC = true;
            isPlayerTurn = true;
            player1Score = 0;
            player2Score = 0;
            player1RollsList.Items.Clear();
            player2RollsList.Items.Clear();
            player1ScoreLabel.Text = "Игрок: 0";
            player2ScoreLabel.Text = "Компьютер: 0";
            rollButton.Enabled = true;
        }

        private void playerVsPlayerButton_Click(object sender, EventArgs e)
        {
            gameModeVsPC = false;
            isPlayerTurn = true;
            player1Score = 0;
            player2Score = 0;
            player1RollsList.Items.Clear();
            player2RollsList.Items.Clear();
            player1ScoreLabel.Text = "Игрок 1: 0";
            player2ScoreLabel.Text = "Игрок 2: 0";
            rollButton.Enabled = true;
        }
    }

    public class RandomResult
    {
        public Random result { get; set; }
    }

    public class Random
    {
        public RandomData random { get; set; }
    }

    public class RandomData
    {
        public int[] data { get; set; }
    }
}
