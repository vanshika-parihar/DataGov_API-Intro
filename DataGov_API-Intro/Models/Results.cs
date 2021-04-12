namespace DataGov_API_Intro.Models
{
    public class Results
    {
        public Result[] results { get; set; }
    }
    public class Result
    {
        public int data_year { get; set; }
        public int population { get; set; }
        public int total_agency_count { get; set; }
        public int published_agency_count { get; set; }
        public int active_agency_count { get; set; }
        public int covered_agency_count { get; set; }
        public int population_covered { get; set; }
        public int agency_count_nibrs_submitting { get; set; }
        public int agency_count_leoka_submitting { get; set; }
        public int agency_count_pe_submitting { get; set; }
        public int agency_count_srs_submitting { get; set; }
        public int agency_count_asr_submitting { get; set; }
        public int agency_count_hc_submitting { get; set; }
        public int agency_count_supp_submitting { get; set; }
        public int nibrs_population_covered { get; set; }
        public int total_population { get; set; }
        public float nibrs_population_percentage_covered { get; set; }
        public string csv_header { get; set; }
    }
}
