using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermaCulture.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection Configure(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {

            // Earthlink.Infra
            //services.AddMemoryCache();
            //services.AddScoped<IAppSecretKeyProvider, EisApiKeyProvider>();
            //services.AddScoped<IRequestFactory, SignedRequestFactory>();
            //services.AddScoped<IRequestSender, RequestSender>();

            // Services
            services.AddScoped<ICategoryContext, CategoryContext>();
            //services.AddScoped<IArtistService, ArtistService>();
            //services.AddScoped<ICommentService, CommentService>();
            //services.AddScoped<IEditorialService, EditorialService>();
            //services.AddScoped<IEisService, EisService>();
            //services.AddScoped<IFavoriteService, FavoriteService>();
            //services.AddScoped<IFeaturedService, FeaturedService>();
            //services.AddScoped<IGenreService, GenreService>();
            //services.AddScoped<ILikeService, LikeService>();
            //services.AddScoped<IPlaylistService, PlaylistService>();
            //services.AddScoped<IRatingService, RatingService>();
            //services.AddScoped<ITrackQueueService, TrackQueueService>();
            //services.AddScoped<ITrackService, TrackService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ISearchService, SearchService>();
            //services.AddScoped<IHomeService, HomeService>();
            //services.AddScoped<IUserDetailService, UserDetailService>();
            //services.AddScoped<IUserInfoService, UserInfoService>();
            //services.AddScoped<IUserPlayedTrackService, UserPlayedTrackService>();

            // Repositories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<IArtistRepository, Repository.EFCore.ArtistRepository>();
            //services.AddScoped<ICommentRepository, Repository.EFCore.CommentRepository>();
            //services.AddScoped<IEditorialRepository, Repository.EFCore.EditorialRepository>();
            //services.AddScoped<IFavoriteRepository, Repository.EFCore.FavoriteRepository>();
            //services.AddScoped<IGenreRepository, Repository.EFCore.GenreRepository>();
            //services.AddScoped<IPlaylistRepository, Repository.EFCore.PlaylistRepository>();
            //services.AddScoped<ITrackQueueRepository, Repository.EFCore.TrackQueueRepository>();
            //services.AddScoped<ITrackRepository, Repository.EFCore.TrackRepository>();
            //services.AddScoped<IUserLockRepository, Repository.EFCore.UserLockRepository>();
            //services.AddScoped<IUserItemsRepository, Repository.EFCore.UserItemsRepository>();
            //services.AddScoped<IUserRepository, Repository.EFCore.UserRepository>();
            //services.AddScoped<IRatingRepository, Repository.EFCore.RatingRepository>();
            //services.AddScoped<IUserSearchRepository, Repository.EFCore.UserSearchRepository>();
            //services.AddScoped<IUserPlayedTrackRepository, Repository.EFCore.UserPlayedTrackRepository>();

            //// Cache
            //services.AddScoped<IAlbumCacheRepository, AlbumCacheRepository>();

            return services;
        }
    }
}