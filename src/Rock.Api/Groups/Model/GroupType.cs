using Rock.Api.Model;
using System;

namespace Rock.Api.Groups.Model {
    public class GroupType : ApiModel {
        public GroupType() {

        }

        public bool IsSystem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupTerm { get; set; }
        public string GroupMemberTerm { get; set; }
        public int DefaultGroupRoleId { get; set; }
        public bool AllowMultipleLocations { get; set; }
        public bool ShowInGroupList { get; set; }
        public bool ShowInNavigation { get; set; }
        public string IconCssClass { get; set; }
        public bool TakesAttendance { get; set; }
        public bool AttendanceCountsAsWeekendService { get; set; }
        public bool SendAttendanceReminder { get; set; }
        public bool ShowConnectionStatus { get; set; }
        public bool ShowMaritalStatus { get; set; }
        public int AttendanceRule { get; set; }
        public int GroupCapacityRule { get; set; }
        public int AttendancePrintTo { get; set; }
        public int Order { get; set; }
        public object InheritedGroupTypeId { get; set; }
        public int AllowedScheduleTypes { get; set; }
        public int LocationSelectionMode { get; set; }
        public bool EnableLocationSchedules { get; set; }
        public object GroupTypePurposeValueId { get; set; }
        public bool IgnorePersonInactivated { get; set; }
        public bool IsIndexEnabled { get; set; }
        public bool GroupsRequireCampus { get; set; }
        public bool GroupAttendanceRequiresLocation { get; set; }
        public bool GroupAttendanceRequiresSchedule { get; set; }
        public string GroupViewLavaTemplate { get; set; }
        public bool AllowSpecificGroupMemberAttributes { get; set; }
        public bool EnableSpecificGroupRequirements { get; set; }
        public bool AllowGroupSync { get; set; }
        public bool AllowSpecificGroupMemberWorkflows { get; set; }
        public bool EnableGroupHistory { get; set; }
        public object GroupTypeColor { get; set; }
        public object GroupStatusDefinedTypeId { get; set; }
        public object DefaultGroupRole { get; set; }
        public object GroupTypePurposeValue { get; set; }
        public object CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public object CreatedByPersonAliasId { get; set; }
        public int ModifiedByPersonAliasId { get; set; }
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }
        public object Attributes { get; set; }
        public object AttributeValues { get; set; }
        public string Guid { get; set; }
        public object ForeignId { get; set; }
        public object ForeignGuid { get; set; }
        public object ForeignKey { get; set; }
    }

}
