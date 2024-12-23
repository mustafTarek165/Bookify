﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.shared
{
    public record Currency
    {
        internal static readonly Currency None = new("");

        public static readonly Currency Usd = new("USD");
        public static readonly Currency Eur = new("EUR");
        public string Code { get; init; }
        private Currency(string code) => Code = code;

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(x => x.Code == code) ?? throw new ApplicationException("The currency code is invalid");
        }
        public static IReadOnlyCollection<Currency> All = new[]
        {
            Usd,
            Eur
        };
    }
}
