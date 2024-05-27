using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using StrategyFiles;
using StrategyFiles.DiscountStrategies;
using StrategyFiles.Enum;
using StrategyTests;
using StrategyTests.Tests;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace StrategyFiles.Tests
{
    public class StrategiesTests
    {
        [Fact]
        public void PurchaseData_Should_Be_Expected_QuantityStrategy_5_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new QuantityStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 15, //5% para aplicar
                PurchaseSeason = Season.Winter,
                IsVIP = false,
                SpecialPurchase = false
            };

            double appliedDiscount = discounter.ExecuteStrategy(new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase));
            double finalAmountToPay = data.MoneySpent - appliedDiscount;
            PurchaseData output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(95.00);
            output.DiscountApplied.Should().Be(5.00);
        }

        [Fact]
        public void PurchaseData_Should_Be_Expected_QuantityStrategy_10_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new QuantityStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25, //10% para aplicar
                PurchaseSeason = Season.Winter,
                IsVIP = false,
                SpecialPurchase = false
            };
            var appliedDiscount = discounter.ExecuteStrategy(new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase));
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            PurchaseData output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(90.00);
            output.DiscountApplied.Should().Be(10.00);
        }

        [Fact]
        public void PurchaseData_Should_Be_Expected_QuantityStrategy_No_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new QuantityStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 5, //aqui no aplica nadaaaa
                PurchaseSeason = Season.Winter,
                IsVIP = false,
                SpecialPurchase = false
            };

            var appliedDiscount = discounter.ExecuteStrategy(new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase));
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            PurchaseData output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(100.00);
            output.DiscountApplied.Should().Be(0.00);
        }
        [Fact]
        public void PurchaseData_Should_Be_Expected_SeasonStrategy_10_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new SeasonStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25,
                PurchaseSeason = Season.Christmas,
                IsVIP = false,
                SpecialPurchase = false
            };

            var appliedDiscount = discounter.ExecuteStrategy(new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase));
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            PurchaseData output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(90.00);
            output.DiscountApplied.Should().Be(10.00);
        }

        [Fact]
        public void PurchaseData_Should_Be_Expected_SeasonStrategy_15_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new SeasonStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25,
                PurchaseSeason = Season.Summer,
                IsVIP = false,
                SpecialPurchase = false
            };

            var appliedDiscount = discounter.ExecuteStrategy(new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase));
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            PurchaseData output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(85.00);
            output.DiscountApplied.Should().Be(15.00);
        }

        [Fact]
        public void PurchaseData_Should_Be_Expected_SeasonStrategy_No_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new SeasonStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25,
                PurchaseSeason = Season.Winter,
                IsVIP = false,
                SpecialPurchase = false
            };

            var appliedDiscount = discounter.ExecuteStrategy(new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase));
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            PurchaseData output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(100.00);
            output.DiscountApplied.Should().Be(0.00);
        }
        [Fact]
        public void PurchaseData_Should_Be_Expected_SpecialStrategy_20_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new SpecialStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25,
                PurchaseSeason = Season.Winter,
                IsVIP = true, // VIP
                SpecialPurchase = false
            };

            var purchase = new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase);

            var appliedDiscount = discounter.ExecuteStrategy(purchase);
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            var output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(80.00); // 20% descuento
            output.DiscountApplied.Should().Be(20.00);
        }

        [Fact]
        public void PurchaseData_Should_Be_Expected_SpecialStrategy_25_Percent_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new SpecialStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25,
                PurchaseSeason = Season.Winter,
                IsVIP = false,
                SpecialPurchase = true 
            };

            var purchase = new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase);

            var appliedDiscount = discounter.ExecuteStrategy(purchase);
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            var output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(75.00); // 25% de descuento
            output.DiscountApplied.Should().Be(25.00);
        }

        [Fact]
        public void PurchaseData_Should_Be_Expected_SpecialStrategy_No_Discount_Applied()
        {
            Discounter discounter = new Discounter();
            discounter.SetStrategy(new SpecialStrategy());

            var data = new PurchaseTestData()
            {
                MoneySpent = 100,
                PurchasedElements = 25,
                PurchaseSeason = Season.Winter,
                IsVIP = false,
                SpecialPurchase = false 
            };

            var purchase = new Purchase(data.MoneySpent, data.PurchasedElements, data.PurchaseSeason, data.IsVIP, data.SpecialPurchase);

            var appliedDiscount = discounter.ExecuteStrategy(purchase);
            var finalAmountToPay = data.MoneySpent - appliedDiscount;
            var output = new PurchaseData(finalAmountToPay, appliedDiscount);

            output.FinalAmountToPay.Should().Be(100.00); // No hay descuento
            output.DiscountApplied.Should().Be(0.00);
        }
    }
}
