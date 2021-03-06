﻿using GVFS.Common.Git;
using System.IO;

namespace GVFS.Common
{
    public static class GVFSConstants
    {
        public const int ShaStringLength = 40;
        public const int MaxPath = 260;

        public const char PathSeparator = '\\';
        public const char GitPathSeparator = '/';
        public const string GitPathSeparatorString = "/";
        public const char GitCommentSign = '#';

        public const string PrefetchPackPrefix = "prefetch";

        public const string AllZeroSha = "0000000000000000000000000000000000000000";

        public const string GVFSEtwProviderName = "Microsoft.Git.GVFS";

        public const string WorkingDirectoryRootName = "src";
        
        public const string GVFSHooksExecutableName = "GVFS.Hooks.exe";
        public const string GVFSReadObjectHookExecutableName = "GVFS.ReadObjectHook.exe";

        public const string GitIsNotInstalledError = "Could not find git.exe.  Ensure that Git is installed.";

        public const string ExecutableExtension = ".exe";
        public static readonly GitVersion MinimumGitVersion = new GitVersion(2, 13, 0, "gvfs", 1, 0);

        public static class Service
        {
            public const string ServiceName = "GVFS.Service";
            public const string UIName = "GVFS.Service.UI";
        }

        public static class MediaTypes
        {
            public const string PrefetchPackFilesAndIndexesMediaType = "application/x-gvfs-timestamped-packfiles-indexes";
            public const string LooseObjectMediaType = "application/x-git-loose-object";
            public const string CustomLooseObjectsMediaType = "application/x-gvfs-loose-objects";
            public const string PackFileMediaType = "application/x-git-packfile";
        }

        public static class DatabaseNames
        {
            public const string BackgroundGitUpdates = "BackgroundGitUpdates";
            public const string BlobSizes = "BlobSizes";
            public const string PlaceholderList = "PlaceholderList";
            public const string RepoMetadata = "RepoMetadata";
        }

        public static class Endpoints
        {
            public const string GVFSConfig = "/gvfs/config";
            public const string GVFSObjects = "/gvfs/objects";
            public const string GVFSPrefetch = "/gvfs/prefetch";
            public const string GVFSSizes = "/gvfs/sizes";
            public const string InfoRefs = "/info/refs?service=git-upload-pack";
        }

        public static class SpecialGitFiles
        {
            public const string GitAttributes = ".gitattributes";
            public const string GitIgnore = ".gitignore";
        }

        public static class LogFileTypes
        {
            public const string Clone = "clone";
            public const string Dehydrate = "dehydrate";
            public const string Mount = "mount";
            public const string Prefetch = "prefetch";
            public const string Repair = "repair";
            public const string Service = "service";
        }

        public static class DotGVFS
        {
            public const string Root = ".gvfs";
            public static readonly string LogPath = Path.Combine(DotGVFS.Root, "logs");
            public static readonly string GitObjectCachePath = Path.Combine(DotGVFS.Root, "gitObjectCache");
        }

        public static class DotGit
        {
            public const string Root = ".git";
            public const string HeadName = "HEAD";
            public const string IndexName = "index";
            public const string PackedRefsName = "packed-refs";
            public const string LockExtension = ".lock";

            public static readonly string Config = Path.Combine(DotGit.Root, "config");
            public static readonly string Head = Path.Combine(DotGit.Root, HeadName);
            public static readonly string BisectStart = Path.Combine(DotGit.Root, "BISECT_START");
            public static readonly string CherryPickHead = Path.Combine(DotGit.Root, "CHERRY_PICK_HEAD");
            public static readonly string MergeHead = Path.Combine(DotGit.Root, "MERGE_HEAD");
            public static readonly string RevertHead = Path.Combine(DotGit.Root, "REVERT_HEAD");
            public static readonly string RebaseApply = Path.Combine(DotGit.Root, "rebase_apply");
            public static readonly string Index = Path.Combine(DotGit.Root, IndexName);
            public static readonly string IndexLock = Path.Combine(DotGit.Root, IndexName + LockExtension);
            public static readonly string PackedRefs = Path.Combine(DotGit.Root, PackedRefsName);
            public static readonly string Shallow = Path.Combine(DotGit.Root, "shallow");

            public static class Logs
            {
                public static readonly string HeadName = "HEAD";

                public static readonly string Root = Path.Combine(DotGit.Root, "logs");
                public static readonly string Head = Path.Combine(Logs.Root, Logs.HeadName);
            }

            public static class Hooks
            {
                public const string ConfigExtension = ".hooks";
                public const string ConfigNamePrefix = "gvfs.clone.default-";
                public const string LoaderExecutable = "GitHooksLoader.exe";
                public const string PreCommandHookName = "pre-command";
                public const string PostCommandHookName = "post-command";
                public static readonly string ReadObjectName = "read-object";
                public static readonly string Root = Path.Combine(DotGit.Root, "hooks");
                public static readonly string PreCommandPath = Path.Combine(Hooks.Root, PreCommandHookName);
                public static readonly string PostCommandPath = Path.Combine(Hooks.Root, PostCommandHookName);
                public static readonly string ReadObjectPath = Path.Combine(Hooks.Root, ReadObjectName);
            }

            public static class Info
            {
                public const string Name = "info";
                public const string ExcludeName = "exclude";
                public const string AlwaysExcludeName = "always_exclude";
                public const string SparseCheckoutName = "sparse-checkout";

                public static readonly string Root = Path.Combine(DotGit.Root, Info.Name);
                public static readonly string SparseCheckoutPath = Path.Combine(Info.Root, Info.SparseCheckoutName);
                public static readonly string ExcludePath = Path.Combine(Info.Root, ExcludeName);
                public static readonly string AlwaysExcludePath = Path.Combine(Info.Root, AlwaysExcludeName);
            }

            public static class Objects
            {
                public static readonly string Root = Path.Combine(DotGit.Root, "objects");
                
                public static class Info
                {
                    public static readonly string Root = Path.Combine(Objects.Root, "info");
                    public static readonly string Alternates = Path.Combine(Info.Root, "alternates");
                }

                public static class Pack
                {
                    public static readonly string Name = "pack";
                }
            }

            public static class Refs
            {
                public static readonly string Root = Path.Combine(DotGit.Root, "refs");

                public static class Heads
                {
                    public static readonly string Root = Path.Combine(DotGit.Refs.Root, "heads");
                }
            }
        }
    }
}
