using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Shared {
    public class ValidarData {
        public static bool IsData(string data) {

            return DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
