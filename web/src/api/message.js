import request from "./request";

export function fetchMessages(folderId) {
  return request({
    url: `${Office.context.mailbox.restUrl}/v2.0/me/${folderId ? `MailFolders/${folderId}/messages` : 'messages'}?$select=Subject,Sender,SentDateTime`,
    method: 'get'
  })
}