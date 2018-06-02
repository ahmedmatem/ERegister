namespace AMA.ERegister.WebApi.Infrastructure.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Linq;
    using System.Web;

    using AutoMapper.QueryableExtensions;
    using AMA.ERegister.WebApi.App_Start;

    public static class QueryableExtensions
    {
        public static IQueryable<TDestination> ProjectTo<TDestination>(this IQueryable source, params Expression<Func<TDestination, object>>[] membersToExpand)
        {
            return source.ProjectTo(AutoMapperConfig.Configuration, membersToExpand);
        }
    }
}