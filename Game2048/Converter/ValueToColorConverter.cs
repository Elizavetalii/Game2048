using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Game2048.Converter
{
    public class ValueToColorConverter : IValueConverter
    {
        private static readonly Dictionary<string, Brush> titleBrushes = new()
        {
            { "2", App.Current.Resources.MergedDictionaries[0]["tile2Brush"] as SolidColorBrush },
            { "4", App.Current.Resources.MergedDictionaries[0]["tile4Brush"] as SolidColorBrush  },
            { "8", App.Current.Resources.MergedDictionaries[0]["tile8Brush"] as SolidColorBrush  },
            { "16", App.Current.Resources.MergedDictionaries[0]["tile16Brush"] as SolidColorBrush  },
            { "32", App.Current.Resources.MergedDictionaries[0]["tile32Brush"] as SolidColorBrush  },
            { "64", App.Current.Resources.MergedDictionaries[0]["tile64Brush"] as SolidColorBrush  },
            { "128", App.Current.Resources.MergedDictionaries[0]["tile128Brush"] as SolidColorBrush  },
            { "256", App.Current.Resources.MergedDictionaries[0]["tile256Brush"] as SolidColorBrush  },
            { "512", App.Current.Resources.MergedDictionaries[0]["tile512Brush"] as SolidColorBrush  },
            { "1024", App.Current.Resources.MergedDictionaries[0]["tile1024Brush"] as SolidColorBrush  },
            { "2048", App.Current.Resources.MergedDictionaries[0]["tile2048Brush"] as SolidColorBrush  },
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(titleBrushes.TryGetValue((string)value, out Brush brush))
            {
                return brush;
            }
            else
                return App.Current.Resources.MergedDictionaries[0]["tileEmptyBrush"] as SolidColorBrush ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static SolidColorBrush GetSolidColorBrush(byte r, byte g, byte b, byte a)
        {
            return new SolidColorBrush(GetColor(r, g, b, a));
        }

        private static Color GetColor(byte r, byte g, byte b, byte a)
        {
            return new Color { R = r, G = g, B = b, A = a };
        }
    }
}
