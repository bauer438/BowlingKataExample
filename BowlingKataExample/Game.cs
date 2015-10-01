namespace BowlingKataExample
{
    public class Game
    {
        private int total;
        private int[] rolls;
        private int currentRoll;

        public Game()
        {
            total = 0;
            rolls = new int[21];
            currentRoll = 0;
        }

        public void roll(int pins) => rolls[currentRoll++] = pins;

        public int score()
        {
            total = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    total += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    total += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    total += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return total;
        }

        private bool isSpare(int frameIndex) => rolls[frameIndex] + rolls[frameIndex + 1] == 10;

        private bool isStrike(int frameIndex) => rolls[frameIndex] == 10;
    }
}
