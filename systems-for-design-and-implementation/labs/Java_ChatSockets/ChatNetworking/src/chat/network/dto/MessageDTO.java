package chat.network.dto;

import java.io.Serializable;

/**
 * Created by IntelliJ IDEA.
 * User: grigo
 * Date: Mar 18, 2009
 * Time: 4:22:15 PM
 */
public class MessageDTO implements Serializable
{
    private String senderId;
    private String receiverId;
    private String text;

    public MessageDTO(String senderId, String text, String receiverId)
    {
        this.senderId = senderId;
        this.text = text;
        this.receiverId = receiverId;
    }

    public String getSenderId()
    {
        return senderId;
    }

    public String getReceiverId()
    {
        return receiverId;
    }

    public String getText()
    {
        return text;
    }

    @Override
    public String toString()
    {
        return "MessageDTO[" + senderId + " --> " + receiverId + " : " + text + "]";
    }
}
