using System;
using System.Reactive;
using AltitudeAngelWings.Clients.Api.Model;
using GeoJSON.Net.Feature;

namespace AltitudeAngelWings
{
    public interface IMap
    {
        bool Enabled { get; }
        LatLong GetCenter();
        BoundingLatLong GetViewArea();
        void AddOverlay(string name);
        void DeleteOverlay(string name);
        IOverlay GetOverlay(string name, bool createIfNotExists = false);
        IObservable<Unit> MapChanged { get; }
        ObservableProperty<Feature> FeatureClicked { get; }
        void Invalidate();
    }
}