using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class SurveyData
    {
        public int SurveyDataId { get; set; }
        public string UserId { get; set; }
        public int WaveId { get; set; }
        public DateTimeOffset? CompletionDate { get; set; }
        public bool? IsSurveyComplete { get; set; }
        public int? Q1 { get; set; }
        public int? Q21 { get; set; }
        public int? Q22 { get; set; }
        public int? Q23 { get; set; }
        public int? Q24 { get; set; }
        public int? Q25 { get; set; }
        public int? Q26 { get; set; }
        public int? Q27 { get; set; }
        public int? Q28 { get; set; }
        public int? Q29 { get; set; }
        public int? Q210 { get; set; }
        public int? Q211 { get; set; }
        public int? Q212 { get; set; }
        public int? Q3a1 { get; set; }
        public int? Q3a2 { get; set; }
        public int? Q3a3 { get; set; }
        public int? Q3a4 { get; set; }
        public int? Q3a5 { get; set; }
        public int? Q3b1 { get; set; }
        public int? Q3b2 { get; set; }
        public int? Q3b3 { get; set; }
        public int? Q3b4 { get; set; }
        public int? Q3b5 { get; set; }
        public int? Q41 { get; set; }
        public int? Q42 { get; set; }
        public int? Q43 { get; set; }
        public int? Q44 { get; set; }
        public int? Q45 { get; set; }
        public int? Q46 { get; set; }
        public int? Q51 { get; set; }
        public int? Q52 { get; set; }
        public int? Q53 { get; set; }
        public int? Q54 { get; set; }
        public int? Q55 { get; set; }
        public int? Q61 { get; set; }
        public int? Q62 { get; set; }
        public int? Q63 { get; set; }
        public int? Q64 { get; set; }
        public int? Q65 { get; set; }
        public int? Q7a1 { get; set; }
        public int? Q7a2 { get; set; }
        public int? Q7a3 { get; set; }
        public int? Q7a4 { get; set; }
        public int? Q7a5 { get; set; }
        public int? Q7b1 { get; set; }
        public int? Q7b2 { get; set; }
        public int? Q7b3 { get; set; }
        public int? Q7b4 { get; set; }
        public int? Q7b5 { get; set; }
        public int? Q81 { get; set; }
        public int? Q82 { get; set; }
        public int? Q83 { get; set; }
        public int? Q84 { get; set; }
        public int? Q85 { get; set; }
        public int? Q9 { get; set; }
        public int? Q101 { get; set; }
        public int? Q102 { get; set; }
        public int? Q111 { get; set; }
        public int? Q112 { get; set; }
        public int? Q121 { get; set; }
        public int? Q122 { get; set; }
        public int? Q131 { get; set; }
        public int? Q132 { get; set; }
        public int? Q133 { get; set; }
        public int? Q134 { get; set; }
        public int? Q135 { get; set; }
        public int? Q141 { get; set; }
        public int? Q142 { get; set; }
        public int? Q143 { get; set; }
        public int? Q144 { get; set; }
        public int? Q145 { get; set; }
        public int? Q146 { get; set; }
        public int? Q147 { get; set; }
        public int? Q148 { get; set; }
        public int? Q149 { get; set; }
        public int? Q1410 { get; set; }
        public int? Q151 { get; set; }
        public int? Q152 { get; set; }
        public int? Q153 { get; set; }
        public int? Q154 { get; set; }
        public int? Q155 { get; set; }
        public int? Q156 { get; set; }
        public int? Q157 { get; set; }
        public int? Q158 { get; set; }
        public int? Q159 { get; set; }
        public int? Q1510 { get; set; }
        public int? Q161 { get; set; }
        public int? Q162 { get; set; }
        public int? Q163 { get; set; }
        public int? Q164 { get; set; }
        public int? Q165 { get; set; }
        public int? Q17 { get; set; }
        public int? Q181 { get; set; }
        public int? Q182 { get; set; }
        public int? Q183 { get; set; }
        public int? Q184 { get; set; }
        public int? Q185 { get; set; }
        public int? Q186 { get; set; }
        public int? Q187 { get; set; }
        public int? Q191 { get; set; }
        public int? Q192 { get; set; }
        public int? Q193 { get; set; }
        public int? Q194 { get; set; }
        public int? Q195 { get; set; }
        public int? Q196 { get; set; }
        public int? Q197 { get; set; }
        public int? Q198 { get; set; }
        public int? Q199 { get; set; }
        public int? Q1910 { get; set; }
        public int? Q20 { get; set; }
        public int? Q2111 { get; set; }
        public int? Q2121 { get; set; }
        public int? Q213 { get; set; }
        public int? Q214 { get; set; }
        public int? Q215 { get; set; }
        public int? Q216 { get; set; }
        public int? Q217 { get; set; }
        public int? Q221 { get; set; }
        public int? Q231 { get; set; }
        public int? Q232 { get; set; }
        public bool IsBenchmark { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual Wave Wave { get; set; }
    }
}
