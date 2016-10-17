using System;

namespace LanguageFeatures {

    public interface IMonthProvider {
        string GetCurrent();
    }

    public interface IYearProvider {
        string GetCurrent();
    }

    public class TimeProvider : IMonthProvider, IYearProvider {
        private DateTime now = DateTime.Now;

        string IMonthProvider.GetCurrent() {
            return now.ToString("MMM");
        }

        string IYearProvider.GetCurrent() {
            return now.Year.ToString();
        }
    }
}