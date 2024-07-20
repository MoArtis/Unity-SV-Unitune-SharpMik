namespace SharpMik.Drivers
{
    public class UnityDriver : VirtualSoftwareDriver
    {
        public UnityDriver()
        {
            m_Next = null;
            m_Name = "Unity Driver";
            m_Version = "Unity 1.0";
            m_HardVoiceLimit = 0;
            m_SoftVoiceLimit = 255;
            m_AutoUpdating = false;
        }

        public override bool IsPresent() => true;
    }
}