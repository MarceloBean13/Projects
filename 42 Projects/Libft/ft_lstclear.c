/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstclear.c                                      :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:39:01 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:39:59 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_lstclear(t_list **list, void (*del)(void *))
{
	t_list	**temp1;
	t_list	*temp2;

	temp1 = list;
	if (!del)
		return ;
	while (*list && list)
	{
		del((void *)(*list)->content);
		temp2 = (*list)->next;
		free(*list);
		(*list) = temp2;
	}
	if (temp1)
		*temp1 = NULL;
}
