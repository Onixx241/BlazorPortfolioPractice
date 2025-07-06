public class ThemeService 
{
    public string teststring { get; set; } = "this came from a service, yay dependency injection !";

    public bool isDarkMode { get; set; } = false;

    public string mainBackground { get; set; } = "#DFD0B8";
    public string altBackground { get; set; } = "#131010";

    public string currentBackground { get; set; } = "#DFD0B8";

    public string mainColumnColor { get; set; } = "#948979";
    public string altColumnColor { get; set; } = "#393E46";
    public string currentColumnColor { get; set; } = "#948979";

    public string mainTextColor { get; set; } = "#E5E0D8";
    public string altTextColor { get; set; } = "#DDE6ED";
    public string currentTextColor { get; set; } = "#E5E0D8";


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
