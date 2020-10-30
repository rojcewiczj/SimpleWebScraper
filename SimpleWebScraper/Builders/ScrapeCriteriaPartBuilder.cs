using SimpleWebScraper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.Builders
{
    class ScrapeCriteriaPartBuilder
    {

        private string _regex;
        private RegexOptions _regexOption;

        public ScrapeCriteriaPartBuilder()
        {
            setDefaults();
        }

        private void setDefaults()
        {
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
        }

        public ScrapeCriteriaPartBuilder withRegex(string regex)
        {
            _regex = regex;
            return this;
        }

        public ScrapeCriteriaPartBuilder withRegexOption(RegexOptions option)
        {
            _regexOption = option;
            return this;

        }

        public ScrapeCriteriaPart Build()
        {
            ScrapeCriteriaPart part = new ScrapeCriteriaPart();

            part.Regex = _regex;
            part.RegexOption = _regexOption;
            return part;
        }
        //public string Regex { get; set; }
        //public RegexOptions RegexOption { get; set; }
    }
}
