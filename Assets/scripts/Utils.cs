using UnityEngine;

public static class Utils
{
    public static bool CheckInBoundary (Collider boxCollider, Vector3 mousePosition)
    {
        var mousePosInWorld = Camera.main.ScreenToWorldPoint(mousePosition);
        var boxColliderMaxX = boxCollider.bounds.max.x;
        var boxColliderMaxY = boxCollider.bounds.max.y;
        var boxColliderMinX = boxCollider.bounds.min.x;
        var boxColliderMinY = boxCollider.bounds.min.y;
        var normalMousePositionX = mousePosInWorld.x;
        var normalMousePositionY = mousePosInWorld.y;
        return (normalMousePositionX < boxColliderMaxX 
                && normalMousePositionY < boxColliderMaxY
                && normalMousePositionX > boxColliderMinX 
                && normalMousePositionY > boxColliderMinY);
    }
}