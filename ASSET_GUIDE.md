# Flappy Bird Game - Asset Management Guide

## Overview
This Flappy Bird game has been designed with a flexible asset system that allows you to easily swap out visual and audio assets without modifying any code.

## How to Add Your Own Assets

### Asset Pack Structure
To create a new asset pack, create a folder in `wwwroot/assets/flappybird/` with your pack name. For example:
```
wwwroot/assets/flappybird/
├── classic/
├── modern/
└── your-custom-pack/
```

### Required Files for Each Asset Pack
Each asset pack folder should contain these files:

#### Visual Assets
- `background.png` - Background image (will scroll horizontally)
- `bird.png` - Bird sprite (40x30px recommended)
- `pipe.png` - Pipe image (80px wide, any height)
- `ground.png` - Ground texture (will scroll horizontally)

#### Audio Assets (Optional)
- `jump.wav` - Sound when bird flaps
- `score.wav` - Sound when scoring points
- `gameover.wav` - Sound when game ends

### Asset Specifications

#### Recommended Dimensions
- **Bird**: 40x30 pixels
- **Pipe**: 80px wide (height flexible)
- **Background**: Any size (will repeat horizontally)
- **Ground**: Any size (will repeat horizontally)

#### Supported Formats
- **Images**: PNG, JPG, GIF, SVG
- **Audio**: WAV, MP3, OGG

### How to Use Your Assets

1. **Create your asset pack folder**: 
   ```
   wwwroot/assets/flappybird/my-awesome-pack/
   ```

2. **Add your files**:
   ```
   my-awesome-pack/
   ├── background.png
   ├── bird.png
   ├── pipe.png
   ├── ground.png
   ├── jump.wav
   ├── score.wav
   └── gameover.wav
   ```

3. **Load your pack in the game**:
   - Click the asset pack buttons in the game
   - Or modify the `GameAssetsService.cs` to load your pack by default

### Programmatic Asset Management

#### Loading Asset Packs
```csharp
// Load a complete asset pack
GameAssets.LoadAssetPack("my-awesome-pack");

// Use default colors (no images)
GameAssets.UseDefaultColors();

// Set individual assets
GameAssets.SetCustomAssets(
    backgroundImg: "custom/my-background.png",
    birdImg: "custom/my-bird.png"
);
```

#### Modifying Game Configuration
You can also modify game physics in the `GameAssetsService`:
```csharp
GameAssets.Gravity = 0.6;        // Lower = floatier
GameAssets.JumpForce = -15;      // More negative = higher jumps
GameAssets.PipeSpeed = 2;        // Lower = slower game
GameAssets.PipeGap = 250;        // Larger = easier game
```

## Current Features

### Game Mechanics
- ✅ Physics-based bird movement with gravity
- ✅ Collision detection
- ✅ Score tracking with best score memory
- ✅ Smooth pipe generation and scrolling
- ✅ Animated background and ground scrolling
- ✅ Bird rotation based on velocity

### Controls
- ✅ Spacebar to flap
- ✅ Click to flap
- ✅ Keyboard navigation

### Visual Features
- ✅ Smooth animations
- ✅ CSS gradients for attractive default appearance
- ✅ Responsive game area
- ✅ Professional game screens (start, game over)

### Asset System
- ✅ Hot-swappable asset packs
- ✅ Fallback colors when no images are provided
- ✅ Easy-to-use service for asset management
- ✅ Support for custom individual assets

## Example Asset Packs

The game includes buttons for two example asset packs:

1. **Classic Pack** (`classic/` folder)
   - Traditional Flappy Bird style assets
   - Place your retro-style images here

2. **Modern Pack** (`modern/` folder)
   - Contemporary, sleek design assets
   - Place your modern-style images here

## Tips for Best Results

1. **Use transparent PNGs** for bird and pipe sprites
2. **Keep consistent art style** across all assets in a pack
3. **Test your assets** by loading the pack and playing the game
4. **Optimize file sizes** for better web performance
5. **Use seamless textures** for background and ground that tile well

## Need Help?

The asset system is designed to be simple - just drop your files in the right folder structure and click the load button in the game. The game will automatically handle the rest!
