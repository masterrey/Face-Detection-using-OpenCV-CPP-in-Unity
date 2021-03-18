using UnityEngine;

public class PositionAtFaceScreenSpace : MonoBehaviour
{
    private float _camDistance;

    void Start()
    {
        _camDistance = Vector3.Distance(Camera.main.transform.position, transform.position);
    }

    void Update()
    {
        if (OpenCVFaceDetection.NormalizedFacePositions.Count == 0)
            return;

        //transform.position = Camera.main.ViewportToWorldPoint(new Vector3(OpenCVFaceDetection.NormalizedFacePositions[0].x, OpenCVFaceDetection.NormalizedFacePositions[0].y, OpenCVFaceDetection.NormalizedFacePositions[0].z));

        Vector3 headpos = new Vector3(OpenCVFaceDetection.NormalizedFacePositions[0].x*-20, OpenCVFaceDetection.NormalizedFacePositions[0].y*-20, OpenCVFaceDetection.NormalizedFacePositions[0].z);


        transform.position = Vector3.Lerp(transform.position, headpos, Time.deltaTime);

    }
}
