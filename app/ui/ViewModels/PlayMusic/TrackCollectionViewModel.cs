﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using VLC_WINRT.Common;
using VLC_WINRT.ViewModels.MainPage;
using XboxMusicLibrary.Models;

namespace VLC_WINRT.ViewModels.PlayMusic
{
    public class TrackCollectionViewModel : BindableBase
    {
        private ObservableCollection<MusicLibraryViewModel.TrackItem> _tracksCollection;
        private int _currentTrack = -1;
        private bool _canGoPrevious;
        private bool _canGoNext;

        public TrackCollectionViewModel()
        {
            _tracksCollection = new ObservableCollection<MusicLibraryViewModel.TrackItem>();
        }

        public ObservableCollection<MusicLibraryViewModel.TrackItem> TrackCollection
        {
            get { return _tracksCollection; }
            set { SetProperty(ref _tracksCollection, value); }
        }

        public int CurrentTrack
        {
            get { return _currentTrack; }
            set { SetProperty(ref _currentTrack, value); }
        }

        // Tracks Collection Manager
        public void AddTrack(MusicLibraryViewModel.TrackItem track)
        {
            TrackCollection.Add(track);
        }

        public void AddTrack(List<MusicLibraryViewModel.TrackItem> tracks)
        {
            foreach (MusicLibraryViewModel.TrackItem track in tracks)
                TrackCollection.Add(track);
        }

        public bool CanGoPrevious
        {
            get
            {
                return  _canGoPrevious;
            }
            set { SetProperty(ref _canGoPrevious, value); }
        }
        public bool CanGoNext
        {
            get
            {
                return _canGoNext;
            }
            set { SetProperty(ref _canGoNext, value); }
        }

        public bool IsPreviousPossible()
        {
            bool isPossible = (CurrentTrack > 0);
            CanGoPrevious = isPossible;
            return isPossible;
        }

        public bool IsNextPossible()
        {
            bool isPossible = (TrackCollection.Count != 1) && (CurrentTrack < TrackCollection.Count - 1);
            CanGoNext = isPossible;
            return isPossible;
        }

        public void ResetCollection()
        {
            TrackCollection.Clear();
            CurrentTrack = -1;
        }
    }
}
