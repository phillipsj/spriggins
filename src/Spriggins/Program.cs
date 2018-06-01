using McMaster.Extensions.CommandLineUtils;
using System;
using System.IO;

namespace Spriggins {
    public class Program {
        public static int Main(string[] args) {
            var app = new CommandLineApplication {
                FullName = "spriggins",
                ThrowOnUnexpectedArgument = false
            };
            app.HelpOption(inherited: true);
            app.VersionOption("-v|--version", "0.0.1");

            var optionFile = app.Option("-f|--file <FILE>",
                "The manifest file to create the package.",
                CommandOptionType.MultipleValue);

            app.OnExecute(() => {
                if (!optionFile.HasValue() && !File.Exists("manifest.yml")) {
                    Console.Error.WriteLine(
                        "No configuration file is found or has been provided. Please run the command again.");
                    return 1;
                }

                var file = optionFile.HasValue() ? optionFile.Value() : "manifest.yml";
                var manifest = file.Parse();
                
                return 0;
            });

            return app.Execute(args);
        }
    }
}
