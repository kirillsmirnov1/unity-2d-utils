using UnityEngine;

namespace TwoDimUtils.ScreenEdge
{
    public class ScreenEdges : MonoBehaviour
    {
        private ScreenDimensions _dimensionsProvider;
        private GameObject _edgePrefab; // TODO provide layers

        protected Vector2 Dim;

        private void Start()
        {
            _edgePrefab = (GameObject) Resources.Load("ScreenEdge/ScreenEdge");
            _dimensionsProvider = gameObject.AddComponent<ScreenDimensions>();
            Dim = _dimensionsProvider.Dimensions;
            SpawnEdges();
        }

        private void SpawnEdges()
        {
            SpawnRightEdge();
            SpawnLeftEdge();
            SpawnTopEdge();
            SpawnBottomEdge();
        }
        
        protected virtual void SpawnLeftEdge() => SpawnEdge(Vector3.left * Dim.x, Quaternion.Euler(0, 0, -90), Vector3.one * Dim.y);
        protected virtual void SpawnRightEdge() => SpawnEdge(Vector3.right * Dim.x, Quaternion.Euler(0, 0, 90), Vector3.one * Dim.y);
        protected virtual void SpawnTopEdge() => SpawnEdge(Vector3.up * Dim.y, Quaternion.Euler(0, 0, 180), Vector3.one * Dim.x);
        protected virtual void SpawnBottomEdge() => SpawnEdge(Vector3.down * Dim.y, Quaternion.Euler(0, 0, 0), Vector3.one * Dim.x);

        protected void SpawnEdge(Vector3 pos, Quaternion rot, Vector3 scale)
            => Instantiate(_edgePrefab, pos, rot, transform)
                .transform.localScale = scale;
    }
}