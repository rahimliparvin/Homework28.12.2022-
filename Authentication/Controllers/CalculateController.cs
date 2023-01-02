using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    
    public class CalculateController
    {
        private readonly ICalculateService _service;
        public CalculateController()
        {
            _service= new CalculateService();
        }
        public void MultiplyArrayItems() => Console.WriteLine(_service.MultiplyArrayItems(GetArr()));
        // { 
        // int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
        // var result = GetArr();

        // ICalculateService calculateService = new CalculateService();

        //var result = _service.MultiplyArrayItems(arr);

        // Console.WriteLine(_service.MultiplyArrayItems(GetArr()));

        // }     


        public void SquareOfSumArrayItems() => Console.WriteLine(_service.SquareOfSumArrayItems(GetArr()));
        // {
        //int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
        //var result = GetArr()

        //ICalculateService calculateService = new CalculateService();

        // var result = _service.SquareOfSumArrayItems(arr);

        // Console.WriteLine(_service.SquareOfSumArrayItems(GetArr()));

        // }
        private int[] GetArr() => new[] { 1, 2, 3, 4, 5, 6, 12 };

        //int[] GetArr()
        //{
        // int[] arr = { 1, 2, 3, 4, 5, 6, 12 };

        // return arr;
        //}
    }
}

