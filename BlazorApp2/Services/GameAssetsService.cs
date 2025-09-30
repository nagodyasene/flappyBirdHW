namespace BlazorApp2.Services
{
    public class GameAssetsService
    {
        // Asset paths - easily changeable by modifying these properties
        public string BackgroundImage { get; set; } = "";
        public string BirdImage { get; set; } = "";
        public string PipeImage { get; set; } = "";
        public string GroundImage { get; set; } = "";
        
        // Color fallbacks when no images are provided
        public string BackgroundColor { get; set; } = "#87CEEB"; // Sky blue
        public string BirdColor { get; set; } = "#FFD700"; // Gold
        public string PipeColor { get; set; } = "#228B22"; // Forest green
        public string GroundColor { get; set; } = "#8B4513"; // Saddle brown
        
        // Sound effects (for future implementation)
        public string JumpSound { get; set; } = "";
        public string ScoreSound { get; set; } = "";
        public string GameOverSound { get; set; } = "";
        
        // Game configuration
        public double Gravity { get; set; } = 0.8;
        public double JumpForce { get; set; } = -12;
        public double PipeSpeed { get; set; } = 3;
        public int PipeGap { get; set; } = 200;
        
        // Method to load a complete asset pack
        public void LoadAssetPack(string packName)
        {
            var basePath = $"assets/flappybird/{packName}";
            
            BackgroundImage = $"{basePath}/background.png";
            BirdImage = $"{basePath}/bird.png";
            PipeImage = $"{basePath}/pipe.png";
            GroundImage = $"{basePath}/ground.png";
            
            JumpSound = $"{basePath}/jump.wav";
            ScoreSound = $"{basePath}/score.wav";
            GameOverSound = $"{basePath}/gameover.wav";
        }
        
        // Method to reset to default colors (no images)
        public void UseDefaultColors()
        {
            BackgroundImage = "";
            BirdImage = "";
            PipeImage = "";
            GroundImage = "";
            JumpSound = "";
            ScoreSound = "";
            GameOverSound = "";
        }
        
        // Method to load custom individual assets
        public void SetCustomAssets(string? backgroundImg = null, string? birdImg = null, 
            string? pipeImg = null, string? groundImg = null)
        {
            if (backgroundImg != null) BackgroundImage = backgroundImg;
            if (birdImg != null) BirdImage = birdImg;
            if (pipeImg != null) PipeImage = pipeImg;
            if (groundImg != null) GroundImage = groundImg;
        }
    }
}

