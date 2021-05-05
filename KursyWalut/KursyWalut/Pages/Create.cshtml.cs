using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KursyWalut.Data;
using KursyWalut.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.RegularExpressions;


namespace KursyWalut.Pages
{
    public class CreateModel : PageModel
    {
        private readonly KursyWalut.Data.KursyWalutContext _context;

        public CreateModel(KursyWalut.Data.KursyWalutContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dane Dane { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string timeDate = Dane.date;

             string todayDate = DateTime.Now.ToString("yyyy-MM-dd");



            if (Regex.IsMatch(timeDate, @"^\d{4}$|^\d{4}-((0?\d)|(1[012]))-(((0?|[12])\d)|3[01])$", RegexOptions.IgnoreCase))
            {
                if (Int32.Parse(timeDate.Substring(0, 4)) > Int32.Parse(todayDate.Substring(0, 4)))
                {
                    return RedirectToPage("./Error");
                }
                else if (Int32.Parse(timeDate.Substring(0, 4)) == Int32.Parse(todayDate.Substring(0, 4)))
                {
                    if (Int32.Parse(timeDate.Substring(5, 2)) > Int32.Parse(todayDate.Substring(5, 2)))
                    {
                        return RedirectToPage("./Error");
                    }
                    if (Int32.Parse(timeDate.Substring(5, 2)) == Int32.Parse(todayDate.Substring(5, 2)))
                    {
                        if (Int32.Parse(timeDate.Substring(8, 2)) > Int32.Parse(todayDate.Substring(8, 2)))
                        {
                            return RedirectToPage("./Error");
                        }
                    }
                }


                if (Int32.Parse(timeDate.Substring(0, 4)) < 2000)
                {
                    return RedirectToPage("./Error");
                }
            }
            else
            {
                return RedirectToPage("./Error");
            }



                var ifExists = new List<Dane>();
            ifExists = _context.Dane.Where(x => x.date == timeDate).ToList<Dane>();
            if (ifExists.Count != 0)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                string call = "http://openexchangerates.org/api/historical/" + timeDate + ".json?app_id=23e326842d4044d1a971b4fb0359c5a3";
                HttpClient httpClient = new HttpClient();
                string json = await httpClient.GetStringAsync(call);
                DaneJSON obiektKlasy = JsonConvert.DeserializeObject<DaneJSON>(json);
                Dane.PLN = (float)(Math.Round(Convert.ToDouble(obiektKlasy.rates.PLN), 2));
                Dane.EUR = (float)(Math.Round(Convert.ToDouble(obiektKlasy.rates.EUR), 2));
                //Dane.BTC = obiektKlasy.rates.BTC;
                Dane.BTC = (float)(Math.Round(Convert.ToDouble(obiektKlasy.rates.EUR), 7));
                Dane.COP = (float)(Math.Round(Convert.ToDouble(obiektKlasy.rates.COP), 2));
                Dane.timestamp = obiektKlasy.timestamp;
                _context.Dane.Add(Dane);


                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }





        }
    }
    public class DaneJSON
    {
        public string date { get; set; }
        public int Id { get; set; }
        public int timestamp { get; set; }
        public Przeliczniki rates { get; set; }

    }

    public class Przeliczniki
    {
        public float PLN { get; set; }
        public float EUR { get; set; }
        public float BTC { get; set; }
        public float COP { get; set; }
    }
}

