// System namespaces
global using System;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.Diagnostics;
global using System.Linq.Expressions;
global using System.Net;
global using System.Reflection;
global using System.Security.Claims;
global using System.Security.Cryptography;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Web;
//Mongo
global using MongoDB.Bson.Serialization.Attributes;
global using MongoDB.Bson;
global using MongoDB.Driver;

// Microsoft ASP.NET Core namespaces
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.ModelBinding;

// AutoMapper
global using AutoMapper;

//Shared 
global using anh_ngoc_packaging.Shared.BaseController;
global using anh_ngoc_packaging.Shared.Dto.Response;
global using anh_ngoc_packaging.Shared.Dto.Request;

//Infrastructure
global using anh_ngoc_packaging.Infrastructure.Extenstions;
global using static anh_ngoc_packaging.Infrastructure.Extenstions.ServiceAttribute;
global using anh_ngoc_packagingHelper;
global using anh_ngoc_packaging.Infrastructure.MongoDb;

//Core
global using anh_ngoc_packaging.Core.Models;
global using anh_ngoc_packaging.Core.Constants.ErrorCode;
global using anh_ngoc_packaging.Core.Constants.Product;
global using anh_ngoc_packaging.Core.Entity;

//Presentation
global using anh_ngoc_packaging.Presentation.Pages.Dto.Response;
global using anh_ngoc_packaging.Presentation.Pages.Dto.Request;
global using anh_ngoc_packaging.Presentation.Client.ViewComponents;
//UseCases
global using anh_ngoc_packaging.UseCases;