using System.Text.Json.Serialization;

namespace ChurchServiceCreator;

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.appConfig), TypeInfoPropertyName = "AppConfig")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song), TypeInfoPropertyName = "Song")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song.Attributes), TypeInfoPropertyName = "SongAttributes")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song.Datum), TypeInfoPropertyName = "SongDatum")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song.Links), TypeInfoPropertyName = "SongLinks")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song.Meta), TypeInfoPropertyName = "SongMeta")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song.Parent), TypeInfoPropertyName = "SongParent")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.Song.Root), TypeInfoPropertyName = "SongRoot")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongMatch), TypeInfoPropertyName = "SongMatch")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule), TypeInfoPropertyName = "SongSchedule")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Arrangement),
    TypeInfoPropertyName = "SongScheduleArrangement")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Attributes),
    TypeInfoPropertyName = "SongScheduleAttributes")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Data),
    TypeInfoPropertyName = "SongScheduleData")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Item),
    TypeInfoPropertyName = "SongScheduleItem")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Key),
    TypeInfoPropertyName = "SongScheduleKey")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Links),
    TypeInfoPropertyName = "SongScheduleLinks")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Meta),
    TypeInfoPropertyName = "SongScheduleMeta")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Parent),
    TypeInfoPropertyName = "SongScheduleParent")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Plan),
    TypeInfoPropertyName = "SongSchedulePlan")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Relationships),
    TypeInfoPropertyName = "SongScheduleRelationships")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.Root),
    TypeInfoPropertyName = "SongScheduleRoot")]
[JsonSerializable(typeof(global::ChurchServiceCreator.Models.SongSchedule.ServiceType),
    TypeInfoPropertyName = "SongScheduleServiceType")]
public partial class AppJsonSerializerContext : JsonSerializerContext;
