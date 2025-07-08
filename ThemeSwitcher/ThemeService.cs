public class ThemeService 
{
    public bool isDarkMode { get; set; } = false;

    public string mainBackground { get; set; } = "#3F4E4F";
    public string altBackground { get; set; } = "#131010";

    public string currentBackground { get; set; } = "#3F4E4F";

    public string mainColumnColor { get; set; } = "#A27B5C";
    public string altColumnColor { get; set; } = "#393E46";
    public string currentColumnColor { get; set; } = "#A27B5C";

    public string mainTextColor { get; set; } = "#DCD7C9";
    public string altTextColor { get; set; } = "#DDE6ED";
    public string currentTextColor { get; set; } = "#DCD7C9";


    public void ToggleTheme() 
    {
        isDarkMode = !isDarkMode;
        if (!isDarkMode)
        {
            this.currentBackground = mainBackground;
            this.currentTextColor = mainTextColor;
            this.currentColumnColor = mainColumnColor;
        }
        else 
        {
            this.currentBackground = altBackground;
            this.currentTextColor = altTextColor;
            this.currentColumnColor = altColumnColor;
        }
        Console.WriteLine(currentBackground);

        
    }
}
