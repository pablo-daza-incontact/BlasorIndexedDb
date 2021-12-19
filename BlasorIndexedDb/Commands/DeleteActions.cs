﻿using BlazorIndexedDb.Configuration;
using BlazorIndexedDb.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace BlazorIndexedDb.Commands
{
    /// <summary>
    /// Delete commands
    /// </summary>
    public static class DeleteActions
    {
        /// <summary>
        /// Delete one row from a table
        /// </summary>
        /// <typeparam name="TModel">Table or store to use</typeparam>
        /// <param name="jsRuntime"></param>
        /// <param name="id"></param>
        /// <exception cref="ResponseException"></exception>
        /// <returns></returns>
        public static async ValueTask<ResponseJsDb> DbDelete<TModel>(this IJSRuntime jsRuntime, [NotNull] int id)
        {
            try
            {
                List<ResponseJsDb> result = new List<ResponseJsDb>();
                if (Settings.Initialized)
                {
                    result.AddRange(await jsRuntime.InvokeAsync<List<ResponseJsDb>>($"MyDb.Delete", Settings.Tables.GetTable<TModel>(), id));
                }
                else
                {
                    if (Settings.EnableDebug) Console.WriteLine($"DeleteActions: IndexedDb not initialized yet!");
                    result = new List<ResponseJsDb>();
                    result.Add(new ResponseJsDb { Result = false, Message = $"IndexedDb not initialized yet!" });
                }
                if (result.Count > 0) return result[0];
                else return new ResponseJsDb { Result = false, Message = "No results" };
            }
            catch (ResponseException ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw;
            }
            catch (Exception ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw new ResponseException(nameof(DbDelete), typeof(TModel).Name, ex.Message, ex);
            }

        }

        /// <summary>
        /// Delete one row from a table
        /// </summary>
        /// <typeparam name="TModel">Table or store to use</typeparam>
        /// <param name="jsRuntime"></param>
        /// <param name="id">id from the row to delete</param>
        /// <exception cref="ResponseException"></exception>
        /// <returns></returns>
        public static async ValueTask<ResponseJsDb> DbDelete<TModel>(this IJSRuntime jsRuntime, [NotNull] double id)
        {
            try
            {
                List<ResponseJsDb> result = new List<ResponseJsDb>();

                if (Settings.Initialized)
                {
                    result.AddRange(await jsRuntime.InvokeAsync<List<ResponseJsDb>>($"MyDb.Delete", Settings.Tables.GetTable<TModel>(), id));
                }
                else
                {
                    if (Settings.EnableDebug) Console.WriteLine($"DeleteActions: IndexedDb not initialized yet!");
                    result = new List<ResponseJsDb>();
                    result.Add(new ResponseJsDb { Result = false, Message = $"IndexedDb not initialized yet!" });
                }
                if (result.Count > 0) return result[0];
                else return new ResponseJsDb { Result = false, Message = "No results" };

            }
            catch (ResponseException ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw;
            }
            catch (Exception ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw new ResponseException(nameof(DbDelete), typeof(TModel).Name, ex.Message, ex);
            }

        }


        /// <summary>
        /// Delete one row from a table
        /// </summary>
        /// <typeparam name="TModel">Table or store to use</typeparam>
        /// <param name="jsRuntime"></param>
        /// <param name="id">id from the row to delete</param>
        /// <exception cref="ResponseException"></exception>
        /// <returns></returns>
        public static async ValueTask<ResponseJsDb> DbDelete<TModel>(this IJSRuntime jsRuntime, [NotNull] decimal id)
        {
            try
            {
                List<ResponseJsDb> result = new List<ResponseJsDb>();

                if (Settings.Initialized)
                {
                    result.AddRange(await jsRuntime.InvokeAsync<List<ResponseJsDb>>($"MyDb.Delete", Settings.Tables.GetTable<TModel>(), id));
                }
                else
                {
                    if (Settings.EnableDebug) Console.WriteLine($"DeleteActions: IndexedDb not initialized yet!");
                    result = new List<ResponseJsDb>();
                    result.Add(new ResponseJsDb { Result = false, Message = $"IndexedDb not initialized yet!" });
                }
                if (result.Count > 0) return result[0];
                else return new ResponseJsDb { Result = false, Message = "No results" };
            }
            catch (ResponseException ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw;
            }
            catch (Exception ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw new ResponseException(nameof(DbDelete), typeof(TModel).Name, ex.Message, ex);
            }

        }


        /// <summary>
        /// Delete one row from a table
        /// </summary>
        /// <typeparam name="TModel">Table or store to use</typeparam>
        /// <param name="jsRuntime"></param>
        /// <param name="id">id from the row to delete</param>
        /// <exception cref="ResponseException"></exception>
        /// <returns></returns>
        public static async ValueTask<ResponseJsDb> DbDelete<TModel>(this IJSRuntime jsRuntime, [NotNull] string id)
        {
            try
            {
                List<ResponseJsDb> result = new List<ResponseJsDb>();

                if (Settings.Initialized)
                {
                    result.AddRange(await jsRuntime.InvokeAsync<List<ResponseJsDb>>($"MyDb.Delete", Settings.Tables.GetTable<TModel>(), id));
                }
                else
                {
                    if (Settings.EnableDebug) Console.WriteLine($"DeleteActions: IndexedDb not initialized yet!");
                    result = new List<ResponseJsDb>();
                    result.Add(new ResponseJsDb { Result = false, Message = $"IndexedDb not initialized yet!" });
                }
                if (result.Count > 0) return result[0];
                else return new ResponseJsDb { Result = false, Message = "No results" };
            }
            catch (ResponseException ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw;
            }
            catch (Exception ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw new ResponseException(nameof(DbDelete), typeof(TModel).Name, ex.Message, ex);
            }

        }

        /// <summary>
        /// Delete one row from a table
        /// </summary>
        /// <typeparam name="TModel">Table or store to use</typeparam>
        /// <param name="jsRuntime"></param>
        /// <param name="id">id from the row to delete</param>
        /// <exception cref="ResponseException"></exception>
        /// <returns></returns>
        public static async ValueTask<ResponseJsDb> DbDelete<TModel>(this IJSRuntime jsRuntime, [NotNull] DateTime id)
        {
            try
            {
                List<ResponseJsDb> result = new List<ResponseJsDb>();
                if (Settings.Initialized)
                {
                    result.AddRange(await jsRuntime.InvokeAsync<List<ResponseJsDb>>($"MyDb.Delete", Settings.Tables.GetTable<TModel>(), id));
                }
                else
                {
                    if (Settings.EnableDebug) Console.WriteLine($"DeleteActions: IndexedDb not initialized yet!");
                    result = new List<ResponseJsDb>();
                    result.Add(new ResponseJsDb { Result = false, Message = $"IndexedDb not initialized yet!" });
                }
                if (result.Count > 0) return result[0];
                else return new ResponseJsDb { Result = false, Message = "No results" };
            }
            catch (ResponseException ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw;
            }
            catch (Exception ex)
            {
                if (Settings.EnableDebug) Console.WriteLine($"DbDelete Model: {Settings.Tables.GetTable<TModel>()} Error: {ex}");
                throw new ResponseException(nameof(DbDelete), typeof(TModel).Name, ex.Message, ex);
            }

        }
    }
}
