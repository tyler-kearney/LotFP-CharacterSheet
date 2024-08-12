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

    public string CharacterName { get; set; }
    public string PlayerName { get; set; }
    public string SelectedClass { get; set; }
    public int Level { get; set; }
    public string Alignment { get; set; }
    public int Age { get; set; }
    public int CurrentXp { get; set; }
    public int XpForNextLevel { get; set; }

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