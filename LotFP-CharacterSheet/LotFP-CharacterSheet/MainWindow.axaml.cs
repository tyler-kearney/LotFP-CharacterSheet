using System.Collections.ObjectModel;
using Avalonia.Controls;

namespace LotFP_CharacterSheet;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this; // This is what allows data bindings to work
    }

    public string CharacterName { get; set; } = "Character Name";
    public string PlayerName { get; set; } = "Player Name";
    public string SelectedClass { get; set; } = "Cleric"; // Placeholder can be changed by the combobox
    public int Level { get; set; } = 1;
    public string Alignment { get; set; } = "Neutral"; // See above
    public int Age { get; set; } = 0;
    public string Sex { get; set; } = "undefined";
    public int CurrentXp { get; set; } = 0;
    public int XpForNextLevel { get; set; } = 0;

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