#if AddMarkupPackage
// Markup
global using CommunityToolkit.Maui.Markup;
// Static
global using static CommunityToolkit.Maui.Markup.GridRowsColumns;
global using static Microsoft.Maui.Graphics.Colors;
#else
// Static
global using static Microsoft.Maui.Graphics.Colors;
#endif