﻿using BlasorIndexedDb.Helpers;
using BlasorIndexedDb.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlasorIndexedDb
{
    public static class UpdateActions
    {
        /// <summary>
        /// Update table to a db
        /// </summary>
        /// <param name="jsRuntime"></param>
        /// <param name="rows">data to insert</param>
        /// <returns></returns>
        public static async ValueTask<List<ResponseJsDb>> DbUpdate<T>(this IJSRuntime jsRuntime, List<T> rows)
        {
            List<ResponseJsDb> result;
            if (rows.Count > 0)
            {
                try
                {
                    string data = JsonSerializer.Serialize(rows);
                    result = await jsRuntime.InvokeAsync<List<ResponseJsDb>>("MyDb.Update", Utils.GetName<T>(), data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"DbUpdate Error: {ex}");
                    result = new List<ResponseJsDb>{
                        new ResponseJsDb { Result = false, Message = ex.Message }
                    };
                }
            }
            else result = new List<ResponseJsDb>{
                        new ResponseJsDb { Result = true, Message = "No need update!" }
                    };
            return result;
        }

        /// <summary>
        /// Update table to a db with offline property
        /// </summary>
        /// <param name="jsRuntime"></param>
        /// <param name="rows">data to insert</param>
        /// <returns></returns>
        public static async ValueTask<List<ResponseJsDb>> DbUpdateOffLine<T>(this IJSRuntime jsRuntime, List<T> rows)
        {
            List<ResponseJsDb> result;
            if (rows.Count > 0)
            {
                var expanded = AddOflineProperty.AddOffline(rows);
                try
                {
                    string data = JsonSerializer.Serialize(expanded);
                    result = await jsRuntime.InvokeAsync<List<ResponseJsDb>>("MyDb.Update", Utils.GetName<T>(), data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"DbUpdate Error: {ex}");
                    result = new List<ResponseJsDb>{
                        new ResponseJsDb { Result = false, Message = ex.Message }
                    };
                }
            }
            else result = new List<ResponseJsDb>{
                        new ResponseJsDb { Result = true, Message = "No need update!" }
                    };
            return result;
        }
    }
}
