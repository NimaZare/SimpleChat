using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleChat.Server.Data;
using SimpleChat.Server.Model;

namespace SimpleChat.Server;

[Route("api/[controller]")]
[ApiController]
public class ChatsController(MyDbContext context) : ControllerBase
{
    // GET: api/Chats
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MessageModel>>> GetAllMessages()
    {
        return await context.Messages.ToListAsync();
    }

    // GET: api/Chats/5
    [HttpGet("{id}")]
    public async Task<ActionResult<MessageModel>> GetMessageById(int id)
    {
        var messageModel = await context.Messages.FindAsync(id);

        if (messageModel is null)
        {
            return NotFound();
        }

        return messageModel;
    }

    // PUT: api/Chats/5
    [HttpPut("{id}")]
    public async Task<IActionResult> EditMessageById(int id, MessageModel messageModel)
    {
        if (id != messageModel.Id)
        {
            return BadRequest();
        }

        context.Entry(messageModel).State = EntityState.Modified;

        try
        {
            await context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MessageExists(id))
            {
                return NotFound();
            }
            else
            {
                return BadRequest();
            }
        }

        return Ok();
    }

    // POST: api/Chats
    [HttpPost]
    public async Task<ActionResult<MessageModel>> SendMessage(MessageModel messageModel)
    {
        context.Messages.Add(messageModel);
        try
        {
            await context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("GetChats", new { id = messageModel.Id }, messageModel);
    }

    // DELETE: api/Chats/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMessageById(int id)
    {
        var messageModel = await context.Messages.FindAsync(id);
        if (messageModel is null)
        {
            return NotFound();
        }

        context.Messages.Remove(messageModel);
        try
        {
            await context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Ok();
    }

    private bool MessageExists(int id)
    {
        return context.Messages.Any(e => e.Id == id);
    }
}
