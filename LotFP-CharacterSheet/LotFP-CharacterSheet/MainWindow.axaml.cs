using System.Collections.ObjectModel;
using Avalonia.Controls;

namespace LotFP_CharacterSheet;

public partial class MainWindow : Window
{
    public string CharacterName { get; set; }
    public string PlayerName { get; set; }
    public string SelectedClass { get; set; }
    public int Level { get; set; }
    public string Alignment { get; set; }
    public int Age { get; set; }
    public int CurrentXp { get; set; }
    public int XpForNextLevel { get; set; }

    public ObservableCollection<string> AvailableClasses { get; } = new ObservableCollection<string>()
    {
        "Cleric",
        "Fighter",
        "Magic-User",
        "Specialist",
        "Dwarf",
        "Elf",
        "Halfling"
    };

    public ObservableCollection<string> Alignments { get; } = new ObservableCollection<string>()
    {
        "Lawful",
        "Neutral",
        "Chaotic"
    };
    
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this; // This is what allows data binding to work.
    }
}