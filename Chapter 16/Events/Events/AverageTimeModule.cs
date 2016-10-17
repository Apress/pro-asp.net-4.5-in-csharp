using System;
using System.Web;
using CommonModules;

namespace Events {

    public class AverageTimeEventArgs : EventArgs {
        public double AverageTime { get; set; }
    }

    public class AverageTimeModule : IHttpModule {
        private static double totalTime;
        private static int requestCount;
        private static object lockObject = new object();
        public event EventHandler<AverageTimeEventArgs> NewAverage;

        public void Init(HttpApplication app) {
            for (int i = 0; i < app.Modules.Count; i++) {
                if (app.Modules[i] is TimerModule) {
                    (app.Modules[i] as TimerModule).RequestTimed += (src, args) => {
                        addNewDataPoint(args.Duration);
                    };
                    break;
                }
            }
        }

        private void addNewDataPoint(double duration) {
            lock (lockObject) {
                double ave = (totalTime += duration) / (++requestCount);
                System.Diagnostics.Debug.WriteLine(
                    string.Format("Average request duration: {0:F2}ms", ave));
                if (NewAverage != null) {
                    NewAverage(this, new AverageTimeEventArgs { AverageTime = ave });
                }
            }
        }

        public void Dispose() {
            // nothing to do
        }
    }
}
