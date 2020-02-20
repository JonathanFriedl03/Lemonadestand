using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {
        // member variables (HAS A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;
        //private double weeklyMoneyUsedOnSupplies;
        public double PricePerLemon
        {
            get
            {
                return pricePerLemon;
            }
        }
        public double PricePerSugarCube
        {
            get
            {
                return pricePerSugarCube;
            }
        }
        public double PricePerIceCube
        {
            get
            {
                return pricePerIceCube;
            }
        }
        public double PricePerCup
        {
            get
            {
                return pricePerCup;
            }
        }
        //public double WeeklyMoneyUsedOnSupplies
        //{
        //    get
        //    {
        //        return weeklyMoneyUsedOnSupplies;
        //    }
        //}
        // constructor (SPAWNER)


        public Store()
        {
            pricePerLemon = .5;
            pricePerSugarCube = .1;
            pricePerIceCube = .05;
            pricePerCup = .25;
            //weeklyMoneyUsedOnSupplies = 0;
        }

        // member methods (CAN DO)
        public void SellLemons(Player player, Day day)
        {
            int lemonsToPurchase = UserInterface.GetNumberOfItems("lemons", player.inventory.lemons.Count, player.wallet.Money);
            double transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
            DailyTransaction(player, transactionAmount, day);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddLemonsToInventory(lemonsToPurchase);
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy that!");
                Console.ReadLine();
            }
        }
        
            public void SellSugarCubes(Player player, Day day)
        {
            int sugarToPurchase = UserInterface.GetNumberOfItems("sugar cubes", player.inventory.sugarCubes.Count, player.wallet.Money);
            double transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
            DailyTransaction(player, transactionAmount,day);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubesToInventory(sugarToPurchase);
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy that!");
                Console.ReadLine();
            }
        }

        public void SellIceCubes(Player player, Day day)
        {
            int iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes", player.inventory.iceCubes.Count, player.wallet.Money);
            double transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
            DailyTransaction(player, transactionAmount, day);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy that!");
                Console.ReadLine();
            }
        }

        public void SellCups(Player player,Day day)
        {
            int cupsToPurchase = UserInterface.GetNumberOfItems("cups", player.inventory.cups.Count, player.wallet.Money);
            double transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
            DailyTransaction(player, transactionAmount,day);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddCupsToInventory(cupsToPurchase);
                Console.WriteLine("Ok Time to make your recipe!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy that!");
                Console.ReadLine();
            }
        }
        private void DailyTransaction(Player player, double transactionAmount, Day day)
        {
            player.weeklyMoneyUsedOnSupplies += transactionAmount;
            day.moneyUsedOnSupplies += transactionAmount;
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
    {
        double transactionAmount = itemCount * itemPricePerUnit;
        return transactionAmount;
    }

    private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
