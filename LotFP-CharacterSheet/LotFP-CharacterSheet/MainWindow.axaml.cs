using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace LotFP_CharacterSheet;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this; // This is what allows data bindings to work
    }

    private int Roll()
    {
        int result = 0;
        Random die = new Random();
        for (int i = 1; i < 3; i++)
        {
            result += die.Next(1, 6);
        }
        return result;
    }

    public void OnClick(object sender, RoutedEventArgs e)
    {
        SetScores();
    }

    public void SetScores()
    {
        List<int> scores = new List<int>()
        {
            StrengthScore,
            DexterityScore,
            ConstitutionScore,
            IntelligenceScore, 
            WisdomScore,
            CharismaScore
        };
        
        for (int i = 0; i < scores.Count; i++)
        {
            scores[i] = 0;
        }

        for (int i = 0; i <= scores.Count; i++)
        {
            scores[i] = Roll();
        }
    }

    public string CharacterName { get; set; } = "Character Name";
    public string PlayerName { get; set; } = "Player Name";
    public string SelectedClass { get; set; } = "Cleric"; // Placeholder can be changed by the combobox
    public int Level { get; set; } = 1;
    public string Alignment { get; set; } = "Neutral"; // See above
    public int Age { get; set; }
    public string Sex { get; set; } = "undefined";
    public int CurrentXp { get; set; }
    public int XpForNextLevel { get; set; }
    
    // Ability Scores section
    public int StrengthScore { get; set; } = 3;
    public int DexterityScore { get; set; } = 3;
    public int ConstitutionScore { get; set; } = 3;
    public int IntelligenceScore { get; set; } = 3;
    public int WisdomScore { get; set; } = 3;
    public int CharismaScore { get; set; } = 3;

    public ObservableCollection<string> AvailableClasses { get; } = new()
    {
        "Cleric",
        "Fighter",
        "Magic-User",
        "Specialist",
        "Dwarf",
        "Elf",
        "Halfling"
    };

    public ObservableCollection<string> Alignments { get; } = new()
    {
        "Lawful",
        "Neutral",
        "Chaotic"
    };
}