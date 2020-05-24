import request from "./request";

export function fetchFolders() {
  return request({
    url: `${Office.context.mailbox.restUrl}/v2.0/me/MailFolders`,
    method: 'get'
  })
}