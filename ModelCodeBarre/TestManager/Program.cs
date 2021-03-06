﻿using ModelCodeBarre;
using System;

namespace TestManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager(new ApiLib.ApiDataManager());

            var article = mgr.findArticle("AAAA");

            Console.WriteLine(article != null ? article.ToString() : "pas d'article avec ce code");

            article = mgr.findArticle("AAAB");
            Console.WriteLine(article != null ? article.ToString() : "pas d'article avec ce code");
        }
    }
}
