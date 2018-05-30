using McMaster.Extensions.CommandLineUtils;
using System;

namespace Spriggins {
    public class Program {
        public static int Main(string[] args) {
            var app = new CommandLineApplication {
                FullName = "spriggins",
                ThrowOnUnexpectedArgument = false
            };
            app.HelpOption(inherited: true);
            app.VersionOption("-v|--version", "0.0.1");

            var fileOption = app.Option("-f|--file <FILE>", "The manifest file to create the package.", CommandOptionType.MultipleValue);

            app.OnExecute(() => {
                if (fileOption.HasValue()) {
                    Console.WriteLine("Using the file passed...");
                }
                else {
                    Console.WriteLine("Using the default file...");
                }
            });
            
            return app.Execute(args);
        }
        
    }
}
