using System;

namespace PiSoundBoard.Api.DTOs
{
    public class BuildData
    {
        public string subscriptionId { get; set; }
        public int notificationId { get; set; }
        public string id { get; set; }
        public string eventType { get; set; }
        public string publisherId { get; set; }
        public string scope { get; set; }
        public Message message { get; set; }
        public Detailedmessage detailedMessage { get; set; }
        public Resource resource { get; set; }
        public string resourceVersion { get; set; }
        public Resourcecontainers resourceContainers { get; set; }
        public DateTime createdDate { get; set; }
    }

    public class Message
    {
        public string text { get; set; }
    }

    public class Detailedmessage
    {
        public string text { get; set; }
    }

    public class Resource
    {
        public string uri { get; set; }
        public int id { get; set; }
        public string buildNumber { get; set; }
        public string url { get; set; }
        public DateTime startTime { get; set; }
        public DateTime finishTime { get; set; }
        public string reason { get; set; }
        public string status { get; set; }
        public string dropLocation { get; set; }
        public Drop drop { get; set; }
        public Log log { get; set; }
        public string sourceGetVersion { get; set; }
        public Lastchangedby lastChangedBy { get; set; }
        public bool retainIndefinitely { get; set; }
        public bool hasDiagnostics { get; set; }
        public Definition definition { get; set; }
        public Queue queue { get; set; }
        public Request[] requests { get; set; }
    }

    public class Drop
    {
        public string location { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string downloadUrl { get; set; }
    }

    public class Log
    {
        public string type { get; set; }
        public string url { get; set; }
        public string downloadUrl { get; set; }
    }

    public class Lastchangedby
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string uniqueName { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
    }

    public class Definition
    {
        public int batchSize { get; set; }
        public string triggerType { get; set; }
        public string definitionType { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Queue
    {
        public string queueType { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Request
    {
        public int id { get; set; }
        public string url { get; set; }
        public Requestedfor requestedFor { get; set; }
    }

    public class Requestedfor
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string uniqueName { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
    }

    public class Resourcecontainers
    {
        public Collection collection { get; set; }
        public Account account { get; set; }
        public Project project { get; set; }
    }

    public class Collection
    {
        public string id { get; set; }
    }

    public class Account
    {
        public string id { get; set; }
    }

    public class Project
    {
        public string id { get; set; }
    }
}